using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Reporting
{
    public partial class MonthyReportViewer : Form
    {
        List<DayReport> monthlyReport = new List<DayReport>();
        DayRiseTimes startDay = Cache.currDay;
        public MonthyReportViewer()
        {
            InitializeComponent();
            int month = 1;

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 0; i < daysInMonth[month - 1]; i++)
            {
                DateTime newDate = new DateTime(2022, month, i + 1);
                Cache.currDay = Cache.yearSunTimes.FirstOrDefault(d => d.Day == newDate.Day && d.Month == newDate.Month);
                monthlyReport.Add(DailyReporter.GenerateReport(newDate));
            }
            Cache.currDay = startDay;
            MessageBox.Show("All Done :)");
            foreach (DayReport dayReport in monthlyReport)
            {
                listBox1.Items.Add(dayReport.Date);
                listBox1.Items.Add("$" + dayReport.getEffectiveCost());
                listBox1.Items.Add("$" + dayReport.getGridCost());
                listBox1.Items.Add("$" + dayReport.getNegatedGridCost());
                listBox1.Items.Add("$" + dayReport.getDaySavings());
            }
        }
    }
}
