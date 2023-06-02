using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class DailyReportViewer : Form
    {
        const int PADDING = 5;

        public DailyReportViewer()
        {
            InitializeComponent();

            //once form is initialized, call the main display report method
            process_report();
        }

        private void process_report()
        {
            put_data(DailyReporter.GenerateReport(Cache.currDay.getSunrise()), mainCanvas, Color.Red, 1);
        }

        public void put_data(List<int> heights, Panel targetCanvas, Color lineColor, int width)
        {
            Graphics g = targetCanvas.CreateGraphics();
            int maxVal = heights.Max();
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
            process_report();
        }
    }
}
