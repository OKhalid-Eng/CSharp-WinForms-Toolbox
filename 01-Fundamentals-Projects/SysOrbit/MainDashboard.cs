using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOrbit
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void SysOrbit_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            this.BackColor = Color.FromArgb(255, 240, 245);
            btnSystemAndDisplay.BackColor= Color.FromArgb(30, 41, 59);

            NavButton_Click(btnSystemAndDisplay, EventArgs.Empty);
        }


        private Color hoverColor = Color.FromArgb(59, 130, 246);     
        private Color activeColor = Color.FromArgb(37, 99, 235);     
        private Color defaultColor = Color.Transparent;              
        private Color defaultTextColor = Color.White;              

        private Button activeBtn = null;


        private void NavButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn != activeBtn) 
            {
                btn.BackColor = hoverColor;
                btn.ForeColor = Color.White;
            }
        }

        private void NavButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn != activeBtn)
            {
                btn.BackColor = defaultColor;
                btn.ForeColor = defaultTextColor;
            }

            
        }


        private void NavButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (activeBtn != null)
            {
                activeBtn.BackColor = defaultColor;
                activeBtn.ForeColor = defaultTextColor;
            }

            activeBtn = btn;
            activeBtn.BackColor = activeColor;
            activeBtn.ForeColor = Color.White;
            if (btn.Name == "btnSystemAndDisplay")
            {
                lblTittle.Text = "System & Display Management";
                ucSysAndDisplay1.Visible = true;


            }
            else if (btn.Name == "btnHarwareAndNetwork")
            {
                lblTittle.Text = "Hardware, Audio & Network Management";
                ucSysAndDisplay1.Visible = false;



            }
            else if(btn.Name == "btnOfficeAndAutomation")
            {
                lblTittle.Text = "Office Automation & Outlook Integration";
                ucSysAndDisplay1.Visible = false;


            }
        }



    }
}
