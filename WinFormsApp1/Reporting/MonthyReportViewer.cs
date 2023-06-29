using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Reporting
{
    public partial class MonthyReportViewer : Form
    {
        List<DayReport> monthlyReport = new List<DayReport>();
        public MonthyReportViewer()
        {
            InitializeComponent();
            int month = 1;

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 0; i < daysInMonth[month - 1]; i++)
            {
                monthlyReport.Add(DailyReporter.GenerateReport(new DateTime(2022, month, i + 1)));
            }
            MessageBox.Show("All Done :)");
        }
    }
}
