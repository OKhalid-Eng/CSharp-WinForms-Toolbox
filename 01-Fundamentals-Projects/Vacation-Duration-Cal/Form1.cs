using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime startDate = monthCalendar1.SelectionRange.Start;
            DateTime endDate = monthCalendar1.SelectionRange.End;

            lblStartDate.Text = startDate.ToShortDateString();
            lblEndDate.Text = endDate.ToShortDateString();

            int numOfDays = (endDate - startDate).Days; 

            lblNumOfDays.Text = numOfDays.ToString();


        }
    }
}
