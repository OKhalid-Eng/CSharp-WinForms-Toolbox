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


        int totalSeconds = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalSeconds++;
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

        
            lblTimer.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnStart.Enabled = false;
            btnPause.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            btnStart.Enabled = true;
            btnPause.Enabled = false;
        }
    }
}
