using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckTheLimetSpeed_Click(object sender, EventArgs e)
        {
            int Speed = Convert.ToInt32(mbtSpeed.Text);

            if (Speed>10 && Speed<=80)
            {
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Drive fast, die faster";
                notifyIcon1.BalloonTipText = "Watch U Speed";
                notifyIcon1.ShowBalloonTip(10000);

            }

           else if (Speed > 80 && Speed <= 120)
            {
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Drive fast, die faster";
                notifyIcon1.BalloonTipText = "Slow Down U Speed";
                notifyIcon1.ShowBalloonTip(10000);

            }

            else if (Speed > 120 && Speed <= 200)
            {
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipTitle = "Drive fast, die faster";
                notifyIcon1.BalloonTipText = "U Must To Slow Down!";
                notifyIcon1.ShowBalloonTip(10000);

            }


            else
            {
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipTitle = "Drive fast, die faster";
                notifyIcon1.BalloonTipText = "The Automated Report Was Sent To You Company!";
                notifyIcon1.ShowBalloonTip(10000);

            }
        }
    }
}
