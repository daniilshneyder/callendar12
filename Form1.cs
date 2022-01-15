using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace callendar12
{
    public partial class Form1 : Form
    {
        int month, year;

        public static int static_month, static_year;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthName + " " + year;

            static_month = month;
            static_year = year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for(int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month--;

            static_month = month;
            static_year = year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month++;

            static_month = month;
            static_year = year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
