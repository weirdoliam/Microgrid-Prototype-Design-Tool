using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Reporting;

namespace WinFormsApp1
{

    public partial class DailyReportViewer : Form
    {
        const int PADDING = 5;
        int maxVal = 1;
        Graphics g;
        DayReport currData = null;

        public DailyReportViewer()
        {
            InitializeComponent();
            //once form is initialized, call the main display report method
            g = mainCanvas.CreateGraphics();
            mainCanvas.Invalidate();
        }

        private void process_report()
        {
            if (currData == null)
            {
                DayReport todaysData = DailyReporter.GenerateReport(Cache.currDay.getSunrise());
                maxVal = todaysData.Max();
                currData = todaysData;                
            }
            //Draw!
            put_data(currData.Consumption, mainCanvas, Color.Red, 4);
            put_data(currData.Generation, mainCanvas, Color.Green, 4);
            put_data(currData.BatteryCharge, mainCanvas, Color.Blue, 2);
            put_data(currData.GridNeeds, mainCanvas, Color.Yellow, 2);
        }

        public void put_data(List<int> heights, Panel targetCanvas, Color lineColor, int width)
        {
            if (maxVal == 0) maxVal = 1;
            Pen pen = new Pen(lineColor);
            //ok now display!
            pen.Width = width;
            pen.Color = lineColor;
            int xInc = targetCanvas.Width / 48;
            int x = 0;
            int y = 0;
            int workingHeight = targetCanvas.Height - (int)(targetCanvas.Height * 0.1);

            //actual data
            int prevX = x;
            int prevY = targetCanvas.Height - workingHeight * (int)(heights[0] / maxVal);
            int index = 1;

            foreach (int height in heights)
            {
                x += xInc;
                y = targetCanvas.Height - (int)(workingHeight * height / maxVal);
                g.DrawLine(pen, prevX, prevY - PADDING, x, y - PADDING);
                prevX = x;
                prevY = y;
                index++;
            }
        }

        private void mainCanvas_Paint(object sender, PaintEventArgs e)
        {
            g = mainCanvas.CreateGraphics();
            g.Clear(Color.White);
            process_report();
        }

        private void mainCanvas_Resize(object sender, EventArgs e)
        {
            mainCanvas.Invalidate();
        }
    }
}
