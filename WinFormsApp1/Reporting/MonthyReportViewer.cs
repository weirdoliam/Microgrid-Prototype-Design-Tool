using Nevron.Nov.UI;
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
        //global pens and brushes
        Pen pen = new Pen(Color.Black, 1);
        Brush brush = new SolidBrush(Color.Black);
        SolidBrush stringBrush = new SolidBrush(Color.Black);
        StringFormat drawFormat = new StringFormat();
        Font drawFont = new Font("Arial", 10);
        int maxVal = 2000;
        int PADDING = 5;

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
            drawCheckBoxes();
        }

        private void drawCheckBoxes()
        {
            checkedListBoxData.Items.Clear();
            List<Tuple<string, List<int>>> allLists = monthlyReport[0].TupleList;
            foreach (var tuple in allLists)
            {
                checkedListBoxData.Items.Add(tuple.Item1);
            }
        }

        public void redrawMainGraph()
        {
            //isolated graphics object
            Graphics gCanvas = mainCanvas.CreateGraphics();
      
            gCanvas.Clear(Color.LightGray);
            panelY.Invalidate();
            panelX.Invalidate();

            int points = monthlyReport.Count * 48;
            int xinc = mainCanvas.Width / points;
            //Vertical Lines
            for (int j = 0; j < mainCanvas.Width; j = j + mainCanvas.Width / monthlyReport.Count)
            {
                gCanvas.DrawLine(pen, j, mainCanvas.Height, j, 0);
            }
            
            //horiz lines
            double scale = Math.Floor(maxVal / 50.0) * 5;
            if (maxVal > 10000) scale = Math.Floor(maxVal / 100.0) * 10;

            if (maxVal > 1000000) scale = Math.Floor(maxVal / 100000.0) * 10000;
            if (maxVal == 0) maxVal = 1000;

            int wh = mainCanvas.Height - (int)(mainCanvas.Height * 0.1);
            for (int k = 0; k <= maxVal; k++)
            {
                int yVal = mainCanvas.Height - (int)(wh * k / maxVal);
                if (scale != 0)
                {
                    if (k % scale == 0 & k != 0)
                    {
                        gCanvas.DrawLine(pen, 0, yVal, mainCanvas.Width, yVal);
                    }
                }
            }

            pen.Width = 1;
            pen.Color = Color.Gray;

            //borders
            gCanvas.DrawLine(pen, 1, mainCanvas.Height, 1, 1);
            gCanvas.DrawLine(pen, 1, mainCanvas.Height - 1, mainCanvas.Width, mainCanvas.Height - 1);
            gCanvas.DrawLine(pen, 1, 1, mainCanvas.Width, 1);
            gCanvas.DrawLine(pen, mainCanvas.Width - 1, 0, mainCanvas.Width - 1, mainCanvas.Height);
            int i = 0;
            int y = 10;
            Color[] colors = new Color[] { Color.Green, Color.Red, Color.Blue, Color.Orange, Color.Olive, Color.Gray, Color.Gold };

            //Put all da data
            foreach (var checkedItem in checkedListBoxData.CheckedItems)
            {
                stringBrush.Color = colors[i % colors.Length];
                //Draw the string at the top of the screen, 10 pixel offset both x and y to begin with
                gCanvas.DrawString("---- " + checkedItem.ToString(), new Font("Arial", 10), stringBrush, 10, y);

                put_data(checkedItem.ToString(), gCanvas, xinc, colors[i % colors.Length], 2);
                //offset y by 15 px
                y += 15;
                i++;
            }
        }

        private void put_data(string key, Graphics gCanvas, int xinc, Color color, int width)
        {
            bool zipped = key == "Battery Usage" ? false : true;
            int x = 0;
            foreach (DayReport dayReport in monthlyReport)
            {
                List<int> currData = dayReport.RetrieveItem(key).Item2;
                x = partial_write(currData, mainCanvas, gCanvas, color, xinc, x, width, zipped);
            }
        }


        private int partial_write(List<int> heights, Panel targetCanvas, Graphics g, Color lineColor, int xInc, int startX, int width, bool zipped)
        {
            int zip_amount = 3;
            if (zipped)
            {
                List<int> zippedHeights = new List<int>();
                for (int i = 0; i < heights.Count; i += zip_amount)
                {
                    int tot = 0;
                    for (int j = 0; j < zip_amount; j++)
                    {
                        try
                        {
                            tot += heights[i + j];
                        }
                        catch (Exception e)
                        {
                            //Do nothing!
                        }
                    }
                    zippedHeights.Add(tot);
                }
                heights = zippedHeights;
            }
            if (maxVal == 0) maxVal = 1;
            Pen pen = new Pen(lineColor);
            //ok now display!
            pen.Width = width;
            pen.Color = lineColor;
            int x = startX;
            int y = 0;
            int workingHeight = targetCanvas.Height - (int)(targetCanvas.Height * 0.1);

            //actual data
            int prevX = x;
            int prevY = targetCanvas.Height - workingHeight * (int)(heights[0] / maxVal);

            foreach (int height in heights)
            {
                int tayloredHeight = height < 0 ? 0 : height;
                x = zipped ? x + xInc * zip_amount : x + xInc;
                y = targetCanvas.Height - (int)(workingHeight * tayloredHeight / maxVal);
                g.DrawLine(pen, prevX, prevY - PADDING, x, y - PADDING);
                prevX = x;
                prevY = y;
            }
            return x;
        }

        private void mainCanvas_Paint(object sender, PaintEventArgs e)
        {
            redrawMainGraph();
        }

        private void buttonSetMax_Click(object sender, EventArgs e)
        {
            try
            {
                maxVal = int.Parse(textBoxMax.Text);
                mainCanvas.Invalidate();
            }
            catch
            {
                MessageBox.Show("Oppzies");
            }
        }

        private void panelX_Paint(object sender, PaintEventArgs e)
        {
            Graphics gx = panelX.CreateGraphics();
            int workingWidth = panelX.Width - panelY.Width;
            int xTarre = panelY.Width;
            int points = monthlyReport.Count;

            int xInc = (workingWidth / points) + 1;
            int y = panelX.Height / 2;
            int currTime = 1;

            stringBrush.Color = Color.Black;
            int increment = 1;

            for (int i = 0; i < points; i++)
            {
                if (i % increment == 0) gx.DrawString(currTime + "", drawFont, stringBrush, xTarre+20, y);
                xTarre += xInc;
                currTime += 1;
            }
        }

        private void panelY_Paint(object sender, PaintEventArgs e)
        {
            int unit = 0;
            double scale = Math.Floor(maxVal / 50.0) * 5;

            if (maxVal > 10000)
            {
                unit = 1;
                scale = Math.Floor(maxVal / 100.0) * 10;
            }
            if (maxVal > 1000000)
            {
                scale = Math.Floor(maxVal / 100000.0) * 10000;
                unit = 2;
            }
            //verticle labels
            Graphics gy = panelY.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            int workingHeight = mainCanvas.Height - (int)(mainCanvas.Height * 0.1);
            stringBrush.Color = Color.Black;
            int xVal = panelY.Width;
            if (scale != 0)
            {
                for (int i = 0; i <= maxVal; i++)
                {
                    if (i % scale == 0 & i != 0)
                    {
                        SizeF strSize = gy.MeasureString($"{i}MW", new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point));
                        //int strX = xVal - (int)strSize.Width;
                        int strX = 3;
                        int yVal = mainCanvas.Height - (int)(workingHeight * i / maxVal);
                        if (unit == 0) gy.DrawString(i + "", drawFont, stringBrush, strX, yVal - 9, drawFormat);
                        else if (unit == 1) gy.DrawString(i / 1000 + "kW", drawFont, stringBrush, strX, yVal - 9, drawFormat);
                        else if (unit == 2) gy.DrawString(i / 1000000f + "MW", drawFont, stringBrush, strX, yVal - 9, drawFormat);
                        gy.DrawLine(pen, panelY.Width, yVal, panelY.Width - 10, yVal);
                    }
                }
            }
        }
    }
}
