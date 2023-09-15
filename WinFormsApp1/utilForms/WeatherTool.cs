using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class WeatherTool : Form
    {

        Pen pen = new Pen(Color.Crimson);
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        Graphics mainCanvas = null;
        Font drawFont = new Font("Arial", 10);
        StringFormat drawFormat = new StringFormat();
        List<double> displayedWindspeeds = null;
        List<double> newHeights = null;
        int maxVal = 35;
        int POINTS = 47;
        int px = 0;
        int py = 0;

        public WeatherTool()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            mainCanvas = panelMainCanvas.CreateGraphics();
            labelDate.Text = Cache.currDay.Day + "/" + Cache.currDay.Month;

            updateDraw();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(e.ToString());
            //-----------------Constantly update new speeds
            string date = Cache.currDay.Day + "/" + Cache.currDay.Month + "/" + Cache.currDay.Year;
            Cache.windModel.replaceSpeedsAtDate(date, newHeights);
            updateDraw();
        }

        public void updateDraw()
        {
            //------------- DAYLIGHT (BG)
            drawBrush.Color = Color.LightSkyBlue;
            //mainCanvas.FillRectangle(drawBrush, 0, 0, panelMainCanvas.Width, panelMainCanvas.Height);
            mainCanvas.Clear(Color.LightSkyBlue);


            //-------------- CURR HIEGHTS
            string date = Cache.currDay.Day + "/" + Cache.currDay.Month + "/" + Cache.currDay.Year;
            displayedWindspeeds = Cache.windModel.getDailySpeeds(date);
            drawHeights(4, Color.FloralWhite, displayedWindspeeds, mainCanvas);


        }

        private void panelMainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            int height = panelMainCanvas.Height;
            //round down to earliest value
            double interval = panelMainCanvas.Width / POINTS;
            double estimatedSector = e.X / interval;
            Console.WriteLine(estimatedSector);
            Console.WriteLine((int)(estimatedSector));
            int sector = (int)(Math.Round((decimal)(estimatedSector))) - 1;
            //if (estimatedSector - (int)estimatedSector <= 0.5) sector = (int)estimatedSector -1;

            labelWidth.Text = panelMainCanvas.Width + "";
            labelHeight.Text = panelMainCanvas.Height + "";
            labelX.Text = e.X + "";
            labelY.Text = e.Y + "";
            labelSector.Text = sector + "";
            labelxinc.Text = interval + "";
            ///*
            if (displayedWindspeeds != null && sector < POINTS && sector >= 0)
            {
                labelCurrYVal.Text = height - (height * (displayedWindspeeds[sector] / maxVal)) + "";
                labelCurrSpeed.Text = (int)displayedWindspeeds[sector] + "";
            }
            //*/
            double newSpeed = -(maxVal * (e.Y - height)) / height;
            labelNewSpeed.Text = newSpeed.ToString();

            //make a clone of currHeights and draw it
            newHeights = displayedWindspeeds.ToList();

            if (displayedWindspeeds != null && sector < POINTS && sector >= 0)
            {
                newHeights[sector] = newSpeed;
            }
            /*
            //no need to draw bits. Too flashy 
            //drawing bits only if dx and dy is small
            int dx = e.X - px;
            int dy = e.Y - py;
            double dist = Math.Sqrt((dx*dx) + (dy*dy));
            labelDist.Text = dist + "";

            if (dist == 1)
            {
                updateDraw();
                if (newHeights != null) drawHeights(2, Color.Crimson, newHeights, mainCanvas);
            }
            px = e.X;
            py = e.Y;
            //*/
        }

        private void panelMainCanvas_MouseLeave(object sender, EventArgs e)
        {
            updateDraw();
        }

        public int drawHeights(int penWidth, Color penColor, List<double> speeds, Graphics canvas)
        {
            try
            {
                pen.Width = penWidth;
                pen.Color = penColor;

                double xInc = panelMainCanvas.Width / POINTS;
                int x = 0;
                int y = 0;

                if (speeds != null)
                {
                    Point[] points = new Point[speeds.Count + 1];
                    points[0] = new Point(x, (int)(panelMainCanvas.Height - panelMainCanvas.Height * (speeds[0] / maxVal)));

                    int prevX = x;
                    int prevY = (int)(panelMainCanvas.Height - panelMainCanvas.Height * (speeds[0] / maxVal));
                    int index = 1;
                    foreach (int height in speeds)
                    {
                        x += (int)xInc;
                        y = panelMainCanvas.Height - (panelMainCanvas.Height * height / maxVal);
                        pen.Color = Color.LightGray;
                        pen.Width = 1;
                        mainCanvas.DrawLine(pen, x, panelMainCanvas.Height, x, 0);
                        pen.Width = penWidth;
                        pen.Color = Color.White;
                        mainCanvas.DrawLine(pen, prevX, prevY, x, y);
                        prevX = x;
                        prevY = y;
                        points[index] = new Point(x, y);
                        index++;
                    }
                }

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private void panelMainCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            timerMain.Enabled = true;
        }

        private void WeatherTool_Resize(object sender, EventArgs e)
        {
            mainCanvas = panelMainCanvas.CreateGraphics();
            updateDraw();
        }

        private void checkDev_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = checkDev.Checked;
            //labelCurrSpeed.Visible = checkDev.Checked;
            labelCurrYVal.Visible = checkDev.Checked;
            labelX.Visible = checkDev.Checked;
            labelY.Visible = checkDev.Checked;
            labelSector.Visible = checkDev.Checked;
            //labelNewSpeed.Visible = checkDev.Checked;
            labelDist.Visible = checkDev.Checked;
            labelWidth.Visible = checkDev.Checked;
            labelHeight.Visible = checkDev.Checked;
            labelxinc.Visible = checkDev.Checked;
        }

        private void panelMainCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            timerMain.Enabled = false;
        }
    }
}
