using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOrbit
{
    public partial class ucSysAndDisplay : UserControl
    {
        public ucSysAndDisplay()
        {
            InitializeComponent();

        }

        [DllImport("user32.dll")]
        static extern int GetSystemMetrics(int nIndex);

     


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(
          uint action, uint uParam, string vParam, uint winIni);

        // Constants for the function
        public static readonly uint SPI_SETDESKWALLPAPER = 0x14;
        public static readonly uint SPIF_UPDATEINIFILE = 0x01;
        public static readonly uint SPIF_SENDCHANGE = 0x02;


        private void ucSysAndDisplay_Load(object sender, EventArgs e)
        {
        }


        public void SetWallpaper(string path)
        {
            try
            {
                int result = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);

                if (result != 0) // نجاح
                {
                    MessageBox.Show("Wallpaper changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Failed to change the desktop wallpaper. Please check the image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string _selectedImagePath = string.Empty;
        private void btnApplyWallpaper_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedImagePath))
            {
                MessageBox.Show("Please select an image first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetWallpaper(_selectedImagePath);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";

            openFileDialog1.Title = "Change Wallpaper";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _selectedImagePath = openFileDialog1.FileName;

            }
        }

        private void btnGetResolution_Click(object sender, EventArgs e)
        {
            int _screenWidth = GetSystemMetrics(0);  // SM_CXSCREEN = 0
            int _screenHeight = GetSystemMetrics(1); // SM_CYSCREEN = 1

            txtReslution.Text = _screenWidth.ToString() + " X " + _screenHeight.ToString();
        }
    
    }
}
