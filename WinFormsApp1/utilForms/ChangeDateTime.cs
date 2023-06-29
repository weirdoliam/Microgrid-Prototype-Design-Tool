using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ChangeDateTime : Form
    {
        string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        public ChangeDateTime()
        {
            InitializeComponent();
            setDate();
        }


        private void setDate()
        {
            labelDay.Text = Cache.currDay.Day.ToString();
            labelMonth.Text = months[Cache.currDay.Month - 1];
            textBoxSunrise.Text = Cache.currDay.getSunrise24hr();
            textBoxSunset.Text = Cache.currDay.getSunset24hr();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApplyJump_Click(object sender, EventArgs e)
        {
            DateTime newDate = dateTimePicker.Value;
            foreach (DayRiseTimes d in Cache.yearSunTimes)
            {
                if(newDate.Day == d.Day && newDate.Month == d.Month)
                {
                    Cache.currDay = d;
                }
            }
            setDate();
        }

        private void buttonChangeSet_Click(object sender, EventArgs e)
        {
            //parse values
            string sunrise = textBoxSunrise.Text;
            string sunset = textBoxSunset.Text;

            try
            {
                //turn them into dateTime values, with correct date
                CultureInfo provider = CultureInfo.InvariantCulture;
                string month = Cache.currDay.Month + "";
                if (Cache.currDay.Month < 10) month = $"0{month}";
                Cache.currDay.setSunrise(DateTime.ParseExact($"{Cache.currDay.Day}/{month}/{Cache.currDay.Year} {sunrise}", "d/MM/yyyy HHmm", provider));
                Cache.currDay.setSunset(DateTime.ParseExact($"{Cache.currDay.Day}/{month}/{Cache.currDay.Year} {sunset}", "d/MM/yyyy HHmm", provider));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid Date format (24hr, HHmm)");
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTomorrow_Click(object sender, EventArgs e)
        {
            int dayIndex = Cache.yearSunTimes.IndexOf(Cache.currDay);
            dayIndex++;
            if (dayIndex > Cache.yearSunTimes.Count-1) dayIndex = 0;
            Cache.currDay = Cache.yearSunTimes[dayIndex];
            setDate();
        }

        private void buttonYesterday_Click(object sender, EventArgs e)
        {
            int dayIndex = Cache.yearSunTimes.IndexOf(Cache.currDay);
            dayIndex--;
            if (dayIndex < 0) dayIndex = Cache.yearSunTimes.Count-1;
            Cache.currDay = Cache.yearSunTimes[dayIndex];
            setDate();
        }
    }
}
