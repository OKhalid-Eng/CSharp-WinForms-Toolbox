using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {

        private short _NumberOfRound;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbNumRound.SelectedIndex = 0;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            _NumberOfRound = (short)(cbNumRound.SelectedIndex + 1);
            pnStartGame.Visible = false;
            lblRoundNumber.Text = _NumberOfRound.ToString();
        }

        

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Cursor = Cursors.Hand;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Location = new Point(pb.Location.X + 2, pb.Location.Y + 2);
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Location = new Point(pb.Location.X - 2, pb.Location.Y - 2);
        }
    }
}
