using OxyPlot.Axes;
using OxyPlot;
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
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using Nevron.Nov.Chart;
using WinFormsApp1.utilForms;

namespace WinFormsApp1.Reporting
{
    public partial class YearlyPerformance : Form
    {
        List<DayReport> yearlyReport = new List<DayReport>();
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public YearlyPerformance()
        {
            InitializeComponent();

            LoadingScreenManager.ShowLoadingScreen(new BatteryLoading());
            DayRiseTimes startDay = Cache.currDay;

            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= daysInMonth[i - 1]; j++)
                {
                    DateTime newDate = new DateTime(2022, i, j);
                    Cache.currDay = Cache.yearSunTimes.FirstOrDefault(d => d.Day == newDate.Day && d.Month == newDate.Month);
                    yearlyReport.Add(DailyReporter.GenerateReport(newDate));
                }
            }
            doResultsBox();
            Cache.currDay = startDay;
            LoadingScreenManager.HideLoadingScreen();
            updateMainPlot(null);
        }

        private void doResultsBox()
        {
            DayReport currData = yearlyReport[0];
            //Generation Percent - Can be based off day 1
            labelWindPercent.Text = $"{currData.getWindPercent():n0}%";
            labelSolarPercent.Text = $"{currData.getSolarPercent():n0}%";

            //In kWh - Totaled for every single day in the year
            int cleanEnergy = 0;
            int emissionsEnergy = 0;
            int consumption = 0;
            double emissions = 0;
            int net = 0;
            decimal effCost = 0, gridCost = 0, negatedGridCost = 0, gridBuyBack = 0, yearSavings = 0;
            decimal setup = Cache.getSetupCost();

            foreach (DayReport day in yearlyReport)
            {
                cleanEnergy += (int)day.getCleanEnergy();
                emissionsEnergy += (int)day.getEmissionEnergy();
                consumption += (int)day.getConsumption();
                emissions += day.getEmissions();
                effCost += day.getEffectiveCost();
                gridCost += day.getGridCost();
                gridBuyBack += day.getGridBuyBack();
                yearSavings += day.getDaySavings();
            }
            negatedGridCost = effCost - gridCost;
            net = consumption - cleanEnergy;

            int scaleValue = 1;
            string unit = " W";
            //Scaling
            if (consumption > 1000000)
            {
                scaleValue = 1000000;
                unit = " MWh";
            }
            else if (consumption > 1000)
            {
                scaleValue = 1000;
                unit = " kWh";
            }

            //Labels!!!
            labelCo2.Text = $"{Math.Max(Math.Round(emissions / 1000, 2), 0):n} kgCO2/kWh";
            labelDirty.Text = $"{Math.Max(emissionsEnergy / scaleValue, 0):n0} {unit}";
            labelRenew.Text = $"{cleanEnergy / scaleValue:n} {unit}";
            labelTotalConsumption.Text = $"{consumption / scaleValue:n} {unit}";
            labelTotalStorage.Text = currData.GridCapacity.Capacity < 1000000 ? $"{currData.GridCapacity.Capacity / 1000:n} kW" : $"{currData.GridCapacity.Capacity / scaleValue:n} MW";
            labelInternalNet.Text = $"{net / scaleValue:n} {unit}";
            labelInternalNet.ForeColor = net > 0 ? Color.Red : net == 0 ? Color.Gold : Color.Green;
            //Cost Analysis
            // Hamilton	21.2c
            labelEffCost.Text = $"${effCost:n}";
            labelGridCost.Text = $"${gridCost:n}";
            labelSaved.Text = $"${negatedGridCost:n}";
            labelSetupCost.Text = $"${setup:n}";
            labelBuyBack.Text = $"${gridBuyBack:n}";
            double daysTillPayDone = (int)(setup / (yearSavings / 365));

            string time = daysTillPayDone > 183 ? "Years" : daysTillPayDone > 365 ? "Months" : "Days";
            daysTillPayDone = daysTillPayDone > 365 ? daysTillPayDone / 365 : daysTillPayDone > 183 ? daysTillPayDone / 30 : daysTillPayDone;
            labelPayback.Text = $"{Math.Round(daysTillPayDone, 2)} {time}";
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

        private void updateMainPlot(string data)
        {
            LoadingScreenManager.ShowLoadingScreen(new GraphLoading());
            if (data == null)
            {
                data = "Overall Consumption";
            }
            // Create the plot model
            var plotModel = new PlotModel { Title = "Yearly Load Viewer" };

            // Create the scatter series
            FunctionSeries fs = new FunctionSeries
            {
                Color = OxyColors.Blue, // Set the line color
                MarkerType = MarkerType.Circle, // Set the marker type at each data point
                MarkerSize = 2, // Set the size of the marker
                MarkerFill = OxyColors.Blue, // Set the fill color of the marker
                MarkerStroke = OxyColors.Black, // Set the outline color of the marker
                StrokeThickness = 1, // Set the thickness of the line
            };

            //populate datapoints - start with consumption
            int count = 0;
            ///*
            foreach (DayReport d in yearlyReport)
            {
                foreach (int i in d.RetrieveItem(data).Item2)
                {
                    //Console.WriteLine(count + " " + i);
                    fs.Points.Add(new DataPoint(count, i));
                    count++;
                }
            }
            LoadingScreenManager.HideLoadingScreen();
            //*/
            // Add the line series to the plot model
            plotModel.Series.Add(fs);

            // Set the X-axis and Y-axis properties (optional)
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "Consumption" });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "Time" });

            // Set the model to the existing plot view (plotView1)
            mainPlot.Model = plotModel;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            updateDisplayedData();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            updateDisplayedData();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            updateDisplayedData();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            updateDisplayedData();
        }

        private void updateDisplayedData()
        {
            List<RadioButton> butts = new List<RadioButton>();
            butts.Add(rb1);
            butts.Add(rb2);
            butts.Add(rb3);
            butts.Add(rb4);
            var checkedButton = butts.FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                updateMainPlot(checkedButton.Text);
            }
        }
    }
}
