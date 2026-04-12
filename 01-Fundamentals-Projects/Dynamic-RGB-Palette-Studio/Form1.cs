using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void UpdateColor()
        {
            int r = tbRed.Value;
            int g = tbGreen.Value;
            int b = tbBlue.Value;

           
            this.BackColor = Color.FromArgb(r, g, b);

            lblRed.Text = r.ToString();
            lblGreen.Text = g.ToString();
            lblBlue.Text = b.ToString();

            lblRGB.Text = $"RGB( {r} , {g} , {b} )";
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateColor();
        }
    }
}
