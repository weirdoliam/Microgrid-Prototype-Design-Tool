using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.graphing;
using WinFormsApp1.managers;

namespace WinFormsApp1.Reporting
{
    public partial class YearlyPerformance : Form
    {
        List<DayReport> yearlyReport = new List<DayReport>();
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public YearlyPerformance()
        {
            InitializeComponent();

            LoadingScreenManager.ShowLoadingScreen();
            InitializeComponent();
            DayRiseTimes startDay = Cache.currDay;

            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= daysInMonth[i-1]; j++)
                {
                    DateTime newDate = new DateTime(2022, i, j);
                    Cache.currDay = Cache.yearSunTimes.FirstOrDefault(d => d.Day == newDate.Day && d.Month == newDate.Month);
                    yearlyReport.Add(DailyReporter.GenerateReport(newDate));
                }
            }

            Cache.currDay = startDay;
            LoadingScreenManager.HideLoadingScreen();
        }

        private void buttonEnergyBalance_Click(object sender, EventArgs e)
        {
            List<int> initX = new List<int>() { 0 };
            List<int> initY = new List<int>() { 0 };
            EnergyBalanceGraph ebg = new EnergyBalanceGraph(initX, initY);
            foreach (DayReport d in yearlyReport)
            {
                ebg.addPoints(d.RetrieveItem("Balanced Consumption").Item2, d.RetrieveItem("Balanced Generation").Item2);
            }

            ebg.Show();
        }
    }
}
