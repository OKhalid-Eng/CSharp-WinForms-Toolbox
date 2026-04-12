using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

          

        bool IsValid(int Age, bool HasDriveLicence)
        {
            return (Age > 21 && HasDriveLicence);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            int Age = Convert.ToInt32(txtAge.Text);
            bool HasDriveLicence = (txtDriverLicence.Text == "1" || txtDriverLicence.Text.ToLower() == "yes");
            if (IsValid(Age, HasDriveLicence))
                MessageBox.Show("Hire", "Hire A Driver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Rejected", "Hire A Driver", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


    }
}
