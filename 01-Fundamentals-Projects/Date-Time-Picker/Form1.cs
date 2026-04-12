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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime BirthDate = dateTimePicker1.Value;
            DateTime CurrentDate = DateTime.Now;

            float Years = CurrentDate.Year - BirthDate.Year;

            if (CurrentDate.Month<BirthDate.Month||(CurrentDate.Month ==BirthDate.Month
                && CurrentDate.Day<BirthDate.Day))
            {
                Years--;
            }

            lblYear.Text = Years.ToString();

            float Months = 0;
            Months = (Years * 12);

            if (BirthDate.Month > CurrentDate.Month)
                Months += 12 - Math.Abs(CurrentDate.Month - BirthDate.Month);
            else
                Months += CurrentDate.Month - BirthDate.Month;

            if (BirthDate.Day > CurrentDate.Day)
                Months--;

            lblMonth.Text = Months.ToString();
            int TotalDays = (int)(CurrentDate - BirthDate).TotalDays;
            lblDay.Text = TotalDays.ToString();

            lblWeek.Text = (TotalDays / 7).ToString();

            lblHour.Text = (CurrentDate - BirthDate).TotalHours.ToString();

            lblMinutes.Text = (CurrentDate - BirthDate).TotalMinutes.ToString();

            lblSecond.Text = (CurrentDate - BirthDate).TotalSeconds.ToString();

        }


    }
}
