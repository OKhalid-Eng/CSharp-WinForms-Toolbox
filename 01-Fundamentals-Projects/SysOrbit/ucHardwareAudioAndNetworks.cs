using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace SysOrbit
{
    public partial class ucHardwareAudioAndNetworks : UserControl
    {
        // P/Invoke definitions for Memory/Process info
        [DllImport("psapi.dll", SetLastError = true)]
        public static extern bool EnumProcesses([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)][In][Out] uint[] processIds, uint arraySizeBytes, out uint bytesReturned);

        [DllImport("psapi.dll", SetLastError = true)]
        public static extern bool GetProcessMemoryInfo(IntPtr hProcess, out PROCESS_MEMORY_COUNTERS counters, uint size);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, uint processId);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hObject);

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_MEMORY_COUNTERS
        {
            public uint cb;
            public uint PageFaultCount;
            public uint PeakWorkingSetSize;
            public uint WorkingSetSize;
            public uint QuotaPeakPagedPoolUsage;
            public uint QuotaPagedPoolUsage;
            public uint QuotaPeakNonPagedPoolUsage;
            public uint QuotaNonPagedPoolUsage;
            public uint PagefileUsage;
            public uint PeakPagefileUsage;
        }

        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int PROCESS_VM_READ = 0x0010;

        // Define the SYSTEM_POWER_STATUS structure
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_POWER_STATUS
        {
            public byte ACLineStatus;
            public byte BatteryFlag;
            public byte BatteryLifePercent;
            public byte Reserved1;
            public int BatteryLifeTime;
            public int BatteryFullLifeTime;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool GetSystemPowerStatus(out SYSTEM_POWER_STATUS sps);

        public static float GetCurrentVolume()
        {
            try
            {
                using (var enumerator = new MMDeviceEnumerator())
                using (var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia))
                {
                    return device.AudioEndpointVolume.MasterVolumeLevelScalar * 100;
                }
            }
            catch
            {
                return 0;
            }
        }

        public ucHardwareAudioAndNetworks()
        {
            InitializeComponent();

            if (cmListViet.Items.Count > 0)
            {
                cmListViet.SelectedIndex = 0;
            }

            UpdateSystemStatus();
        }

        private void UpdateSystemStatus()
        {
            // Battery Status
            if (GetSystemPowerStatus(out SYSTEM_POWER_STATUS status))
            {
                // ACLineStatus: 1 = Plugged In, 0 = Unplugged / On Battery
                lblBatteryChargeStatus.Text = (status.ACLineStatus == 1) ? "(Plugged In)" : "(Plugged Out)";

                // Battery Percent
                string batteryPercentStr = (status.BatteryLifePercent == 255) ? "Unknown" : status.BatteryLifePercent.ToString() + "%";

                // If you have a separate label for battery percent (e.g. lblBatteryPercent):
                // lblBatteryPercent.Text = batteryPercentStr;
                // Or if battery and audio levels use different labels, assign correctly:
                lblBatteryChargeStatus.Text = $"{batteryPercentStr} {((status.ACLineStatus == 1) ? "(Plugged In)" : "(Plugged Out)")}";
            }

            // Audio Level Status
            float currentVol = GetCurrentVolume();
            lblVolueLev.Text = Math.Round(currentVol).ToString() + "%";
        }

        private void btnRefreshStatus_Click(object sender, EventArgs e)
        {
            UpdateSystemStatus();
        }

        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            // Option 1: Wi-Fi Networks
            if (cmListViet.SelectedIndex == 1)
            {
                var wifiScanner = new WifiScanner();
                var networks = wifiScanner.GetAvailableNetworks();

                if (networks.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Available Wi-Fi Networks:\n");
                    foreach (var net in networks)
                    {
                        sb.AppendLine($"• {net}");
                    }
                    MessageBox.Show(sb.ToString(), "Wi-Fi Networks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Wi-Fi networks found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // Option 2: View Running Processes List
            else if (cmListViet.SelectedIndex == 0)
            {
                string processInfoList = GetRunningProcessesSummary();
                ShowScrollableMessageBox("Running Processes List", processInfoList);
            }
        }

        private string GetRunningProcessesSummary()
        {
            uint[] processIds = new uint[1024];
            uint bytesReturned;
            StringBuilder sb = new StringBuilder();

            if (EnumProcesses(processIds, (uint)processIds.Length * sizeof(uint), out bytesReturned))
            {
                int count = (int)(bytesReturned / sizeof(uint));
                sb.AppendLine($"Total Running Processes: {count}\n");
                sb.AppendLine(string.Format("{0,-10} {1,-30} {2,-15}", "PID", "Process Name", "Memory (KB)"));
                sb.AppendLine(new string('-', 60));

                for (int i = 0; i < count; i++)
                {
                    uint pid = processIds[i];
                    IntPtr processHandle = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_VM_READ, false, pid);

                    if (processHandle != IntPtr.Zero)
                    {
                        PROCESS_MEMORY_COUNTERS memCounters;
                        if (GetProcessMemoryInfo(processHandle, out memCounters, (uint)Marshal.SizeOf(typeof(PROCESS_MEMORY_COUNTERS))))
                        {
                            string processName = "Unknown";
                            try
                            {
                                Process proc = Process.GetProcessById((int)pid);
                                processName = proc.ProcessName;
                            }
                            catch
                            {
                                // Handle system process or access denied
                            }

                            sb.AppendLine(string.Format("{0,-10} {1,-30} {2,-15:N0}", pid, processName, memCounters.WorkingSetSize / 1024));
                        }

                        CloseHandle(processHandle);
                    }
                }
            }
            else
            {
                sb.AppendLine("Failed to enumerate processes.");
            }

            return sb.ToString();
        }

        private void ShowScrollableMessageBox(string title, string content)
        {
            Form messageForm = new Form
            {
                Width = 550,
                Height = 450,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            TextBox txtContent = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 9.75F),
                Text = content
            };

            messageForm.Controls.Add(txtContent);
            messageForm.ShowDialog(this);
        }

        private void ucHardwareAudioAndNetworks_Load(object sender, EventArgs e)
        {

        }
    }

    public class WifiScanner
    {
        [DllImport("Wlanapi.dll")]
        private static extern uint WlanOpenHandle(uint dwClientVersion, IntPtr pReserved, out uint pdwNegotiatedVersion, out IntPtr phClientHandle);

        [DllImport("Wlanapi.dll")]
        private static extern uint WlanEnumInterfaces(IntPtr hClientHandle, IntPtr pReserved, out IntPtr ppInterfaceList);

        [DllImport("Wlanapi.dll")]
        private static extern uint WlanGetAvailableNetworkList(
            IntPtr hClientHandle,
            ref Guid pInterfaceGuid,
            uint dwFlags,
            IntPtr pReserved,
            out IntPtr ppAvailableNetworkList);

        [DllImport("Wlanapi.dll")]
        private static extern uint WlanCloseHandle(IntPtr hClientHandle, IntPtr pReserved);

        [DllImport("Wlanapi.dll")]
        private static extern uint WlanFreeMemory(IntPtr pMemory);

        private IntPtr clientHandle = IntPtr.Zero;

        public WifiScanner()
        {
            uint negotiatedVersion;
            WlanOpenHandle(2, IntPtr.Zero, out negotiatedVersion, out clientHandle);
        }

        ~WifiScanner()
        {
            if (clientHandle != IntPtr.Zero)
            {
                WlanCloseHandle(clientHandle, IntPtr.Zero);
            }
        }

        public List<string> GetAvailableNetworks()
        {
            List<string> networkList = new List<string>();
            IntPtr interfaceListPtr = IntPtr.Zero;

            if (WlanEnumInterfaces(clientHandle, IntPtr.Zero, out interfaceListPtr) == 0 && interfaceListPtr != IntPtr.Zero)
            {
                WlanInterfaceInfoListHeader header = (WlanInterfaceInfoListHeader)Marshal.PtrToStructure(interfaceListPtr, typeof(WlanInterfaceInfoListHeader));
                IntPtr currentPtr = new IntPtr(interfaceListPtr.ToInt64() + 8); // Skip dwNumberOfItems and dwIndex

                for (int i = 0; i < header.dwNumberOfItems; i++)
                {
                    WlanInterfaceInfo info = (WlanInterfaceInfo)Marshal.PtrToStructure(currentPtr, typeof(WlanInterfaceInfo));
                    IntPtr networkListPtr = IntPtr.Zero;

                    if (WlanGetAvailableNetworkList(clientHandle, ref info.InterfaceGuid, 2, IntPtr.Zero, out networkListPtr) == 0 && networkListPtr != IntPtr.Zero)
                    {
                        WlanAvailableNetworkListHeader netListHeader = (WlanAvailableNetworkListHeader)Marshal.PtrToStructure(networkListPtr, typeof(WlanAvailableNetworkListHeader));
                        IntPtr currentNetPtr = new IntPtr(networkListPtr.ToInt64() + 8);

                        for (int j = 0; j < netListHeader.dwNumberOfItems; j++)
                        {
                            WlanAvailableNetwork network = (WlanAvailableNetwork)Marshal.PtrToStructure(currentNetPtr, typeof(WlanAvailableNetwork));
                            string ssid = Encoding.UTF8.GetString(network.dot11Ssid.ucSSID, 0, (int)network.dot11Ssid.uSSIDLength).Trim('\0');

                            if (!string.IsNullOrWhiteSpace(ssid) && !networkList.Contains(ssid))
                            {
                                networkList.Add(ssid);
                            }

                            currentNetPtr = new IntPtr(currentNetPtr.ToInt64() + Marshal.SizeOf(typeof(WlanAvailableNetwork)));
                        }

                        WlanFreeMemory(networkListPtr);
                    }

                    currentPtr = new IntPtr(currentPtr.ToInt64() + Marshal.SizeOf(typeof(WlanInterfaceInfo)));
                }

                WlanFreeMemory(interfaceListPtr);
            }

            return networkList;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct WlanInterfaceInfoListHeader
        {
            public uint dwNumberOfItems;
            public uint dwIndex;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct WlanInterfaceInfo
        {
            public Guid InterfaceGuid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string strInterfaceDescription;
            public int isState;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct WlanAvailableNetworkListHeader
        {
            public uint dwNumberOfItems;
            public uint dwIndex;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct DOT11_SSID
        {
            public uint uSSIDLength;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] ucSSID;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct WlanAvailableNetwork
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string strProfileName;
            public DOT11_SSID dot11Ssid;
            public uint dot11BssType;
            public uint uNumberOfBssids;
            public bool bNetworkConnectable;
            public uint wlanNotConnectableReason;
            public uint uNumberOfPhyTypes;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public uint[] dot11PhyTypes;
            public bool bMorePhyTypes;
            public uint wlanSignalQuality;
            public bool bSecurityEnabled;
            public uint dot11DefaultAuthAlgorithm;
            public uint dot11DefaultCipherAlgorithm;
            public uint dwFlags;
            public uint dwReserved;
        }
    }
}