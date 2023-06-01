using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DailyForecast : Form
    {
        EnergyIn currGen = null;
        int currArrayAmount = 0;
        int currHouseIndex = -1;
        int currGenIndex = -1;
        int cacheValue = 0;

        HouseModel currHouse = null;
        Pen pen = new Pen(Color.Crimson);
        SolidBrush brush = new SolidBrush(Color.Black);
        Graphics g = null;
        Graphics gr = null;
        Graphics box = null;
        Font drawFont = new Font("Arial", 10);
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        StringFormat drawFormat = new StringFormat();
        List<int> genHeights = null;
        List<int> homeHeights = null;
        int maxVal = 2000;
        const int PADDING = 5;
        string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        double percentSunrise = 0;
        double percentSunset = 0;

        bool overlayFactoryLoad = false;
        List<double> factoryHeights = null;

        public DailyForecast()
        {
            InitializeComponent();

            drawFormat.FormatFlags = StringFormatFlags.NoWrap;
            if (Cache.mainFactory.UsesCompLoad)
            {
                factoryHeights = Cache.mainFactory.GetHourlyConsumptionList(Cache.currDay.getSunrise());
            }
            else
            {
                factoryHeights = Cache.mainFactory.GetHourlyConsumptionList();
            }
        }

        //updateListBoxes
        private void updateLists()
        {
            listBoxModelHouses.Items.Clear();
            listBoxGenerators.Items.Clear();
            //add the factory :)
            listBoxModelHouses.Items.Add($"Factory: {Cache.mainFactory.Name}");
            foreach (EnergyOut h in Cache.genListOut)
            {
                listBoxModelHouses.Items.Add(h.ToString());
            }
            foreach (EnergyIn e in Cache.genListin)
            {
                listBoxGenerators.Items.Add(e.getArrayDescription());
            }
        }

        private void updateDate()
        {
            labelCurrDay.Text = $"{months[Cache.currDay.Month - 1]} {Cache.currDay.Day}";
            labelSunrise.Text = Cache.currDay.getSunriseString();
            labelSunset.Text = Cache.currDay.getSunsetString();
            percentSunrise = GetPercentageOfDay(Cache.currDay.getSunrise24hr());
            percentSunset = GetPercentageOfDay(Cache.currDay.getSunset24hr());
        }

        private void listBoxModelHouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxModelHouses.SelectedIndex;
            if (index > 0)
            {
                index -= 1;
                overlayFactoryLoad = false;
                if (Cache.genListOut[index] is HouseModel)
                {
                    currHouseIndex = listBoxModelHouses.SelectedIndex - 1;
                    currHouse = (HouseModel)Cache.genListOut[currHouseIndex];
                    homeHeights = currHouse.getDailyData(Cache.currDay.Day + "/" + Cache.currDay.Month + "/" + Cache.currDay.Year);
                }
            }
            else
            {
                //use factory data
                overlayFactoryLoad = true;
                if (Cache.mainFactory.UsesCompLoad)
                {
                    factoryHeights = Cache.mainFactory.GetHourlyConsumptionList(Cache.currDay.getSunrise());
                }
                else
                {
                    factoryHeights = Cache.mainFactory.GetHourlyConsumptionList();
                }
                homeHeights = null;
            }
            recalculateGenTotals();
        }

        private void listBoxGenerators_SelectedIndexChanged(object sender, EventArgs e)
        {
            currGenIndex = listBoxGenerators.SelectedIndex;
            recalculateGenTotals();
        }

        private void checkBoxArrayTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxGenerators.SelectedIndex != -1) recalculateGenTotals();
        }

        public void recalculateGenTotals()
        {
            try
            {
                currGen = Cache.genListin[listBoxGenerators.SelectedIndex];
                if (currGen is SolarPanelArray)
                {
                    SolarPanelArray array = (SolarPanelArray)currGen;
                    currArrayAmount = array.Amount;
                    currGen = array.getPanelObject();
                }
                else if (currGen is WindTurbineArray)
                {
                    WindTurbineArray array = (WindTurbineArray)currGen;
                    currArrayAmount = array.Amount;
                    currGen = array.getWindTurbine();
                }
                else if (currGen is WindTurbineExisting)
                {
                    WindTurbineExisting turbine = (WindTurbineExisting)currGen;
                    currArrayAmount = 1;
                    currGen = turbine;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //calculating gen heights here
            //how many repeats?
            int repeats = 1;
            //to count accumulative arrays
            int currTotal = 0;
            if (checkBoxArrayTotal.Checked)
            {
                repeats = currArrayAmount;
            }

            genHeights = new List<int>();
            string date = Cache.currDay.Day + "/" + Cache.currDay.Month + "/" + Cache.currDay.Year;

            string currTime = "00:00";
            int hour = 0;
            int minute = 0;
            for (int i = 0; i < 48; i++)
            {
                currTotal = 0;
                for (int j = 0; j < repeats; j++)
                {
                    if (currGen == null) break;
                    currTotal += currGen.getHalfHourlyGeneration(date + $" {currTime}", i);
                    //currTotal += currGen.getHalfHourlyGeneration(date + " " + currTime, i);
                }
                genHeights.Add(currTotal);
                minute += 30;

                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                }
                currTime = hour + ":" + minute;
                if (minute == 0) currTime = currTime + "0";
                if (hour < 10) currTime = "0" + currTime;
            }

            //average heights
            //Home heights done elsewhere

            List<int> contenders = new List<int>();
            //*
            //find the actual hiehgest out of genHeigts and houseHeights
            if (genHeights != null)
            {
                contenders.Add(genHeights.Max());
            }
            if (factoryHeights != null && overlayFactoryLoad)
            {
                contenders.Add((int)factoryHeights.Max());
            }
            if (homeHeights != null)
            {
                contenders.Add(homeHeights.Max());
            }

            maxVal = contenders.Max();
            canvas.Refresh();
            labelPanel.Refresh();
        }

        private void doDrawing()
        {
            doDrawing(1);
        }

        private void doDrawing(double multiple)
        {
            int consume = 0;
            int gen = 0;

            //graph detail

            //draw the sunlight and nighttime graphics if checked (this goes under everything)
            if (checkBoxDaylight.Checked)
            {
                DrawSunlightGradient(g, percentSunrise, percentSunset);
                pen.Color = Color.White;
            }
            else
            {
                pen.Color = Color.LightGray;
            }

            //vert lines
            for (int i = 0; i < canvas.Width; i = i + canvas.Width / 24)
            {
                g.DrawLine(pen, i, canvas.Height, i, 0);

            }

            //horiz lines
            double scale = Math.Floor(maxVal / 50.0) * 5;
            if (maxVal > 10000) scale = Math.Floor(maxVal / 100.0) * 10;

            if (maxVal > 1000000) scale = Math.Floor(maxVal / 100000.0) * 10000;
            if (maxVal == 0) maxVal = 1000;

            int wh = canvas.Height - (int)(canvas.Height * 0.1);
            for (int i = 0; i <= maxVal; i++)
            {
                int yVal = canvas.Height - (int)(wh * i / maxVal);
                if (scale != 0)
                {
                    if (i % scale == 0 & i != 0)
                    {
                        g.DrawLine(pen, 0, yVal, canvas.Width, yVal);
                    }
                }
            }

            pen.Width = 1;
            pen.Color = Color.Black;

            //borders
            g.DrawLine(pen, 1, canvas.Height, 1, 1);
            g.DrawLine(pen, 1, canvas.Height - 1, canvas.Width, canvas.Height - 1);
            g.DrawLine(pen, 1, 1, canvas.Width, 1);
            g.DrawLine(pen, canvas.Width - 1, 0, canvas.Width - 1, canvas.Height);



            //round up to the nearest 500
            int localmaxVal = 500 * (int)Math.Round((decimal)(maxVal / 500));
            //if (localmaxVal < 2000) maxVal = 2000;
            if (localmaxVal > maxVal) maxVal += 500;

            if (listBoxModelHouses.SelectedIndex > 0)
            {
                //display what is in heights
                if (homeHeights != null)
                {
                    put_data(homeHeights, canvas, Color.Crimson, 3);
                    foreach (double height in homeHeights)
                    {
                        consume += (int)height;
                    }
                }
                else
                {
                    //Display err
                    g.DrawString("Data not found", drawFont, drawBrush, canvas.Width / 2, canvas.Height / 2);
                }
            }

            if (listBoxGenerators.SelectedIndex != -1)
            {
                put_data(genHeights, canvas, Color.Green, 3);
                foreach (double height in genHeights)
                {
                    gen += (int)height;
                }
            }

            //display what is in heights
            if (overlayFactoryLoad)
            {
                //Let's make sure we're not getting a specific load first
                if (Cache.mainFactory.UsesCompLoad)
                {
                    factoryHeights = Cache.mainFactory.GetHourlyConsumptionList(Cache.currDay.getSunrise());

                }
                else
                {
                    factoryHeights = Cache.mainFactory.GetHourlyConsumptionList();
                }

                if (factoryHeights == null)
                {
                    g.DrawString("Factory data for today not found.", drawFont, drawBrush, canvas.Width / 2, canvas.Height / 3);
                }
                else
                {
                    //Console.WriteLine($"Recieved factoryHeights OK. Sample:{factoryHeights[5]}, count: {factoryHeights.Count}");
                    //convert to ints
                    List<int> factoryInts = new List<int>();

                    foreach (double h in factoryHeights)
                    {
                        factoryInts.Add((int)h);
                    }
                    //display
                    put_data(factoryInts, canvas, Color.Yellow, 3);
                    foreach (double height in factoryHeights)
                    {
                        consume += (int)height;
                    }
                }

            }
            labelGenerate.Text = gen + " W";
            labelConsume.Text = consume + " W";
            int net = gen - consume;
            labelNet.Text = net + " W";
            if (net < 0) { labelNet.ForeColor = Color.Red; }
            else { labelNet.ForeColor = Color.Green; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = canvas.CreateGraphics();
            doDrawing();
        }


        private void panel1_Paint_1(object sender, PaintEventArgs e)
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
            gr = labelPanel.CreateGraphics();
            pen.Color = Color.Black;
            int workingHeight = canvas.Height - (int)(canvas.Height * 0.1);
            //vertical labels -----------

            for (int i = 0; i <= maxVal; i++)
            {
                int yVal = canvas.Height - (int)(workingHeight * i / maxVal);
                if (scale != 0)
                {
                    if (i % scale == 0 & i != 0)
                    {
                        if (unit == 0) gr.DrawString(i + "", drawFont, drawBrush, 0, yVal - 9, drawFormat);
                        else if (unit == 1) gr.DrawString(i / 1000 + "kW", drawFont, drawBrush, 0, yVal - 9, drawFormat);
                        else if (unit == 2) gr.DrawString(i / 1000000f + "MW", drawFont, drawBrush, 0, yVal - 9, drawFormat);
                        gr.DrawLine(pen, labelPanel.Width, yVal, labelPanel.Width - 5, yVal);
                    }
                }
            }
        }

        public void put_data(List<int> heights, Panel targetCanvas, Color lineColor, int width)
        {
            //ok now display!
            pen.Width = width;
            pen.Color = lineColor;
            int xInc = targetCanvas.Width / 48;
            int x = 0;
            int y = 0;
            int workingHeight = targetCanvas.Height - (int)(targetCanvas.Height * 0.1);

            Point[] points = new Point[heights.Count + 1];
            points[0] = new Point(x, targetCanvas.Height - workingHeight * (int)(heights[0] / maxVal));

            //actual data
            int prevX = x;
            int prevY = targetCanvas.Height - workingHeight * (int)(heights[0] / maxVal);
            int index = 1;

            foreach (int height in heights)
            {
                x += xInc;
                y = targetCanvas.Height - (int)(workingHeight * height / maxVal);
                if (!checkBoxSmooth.Checked)
                {
                    g.DrawLine(pen, prevX, prevY - PADDING, x, y - PADDING);
                }
                prevX = x;
                prevY = y;
                points[index] = new Point(x, y - PADDING);
                index++;
            }
            if (checkBoxSmooth.Checked) g.DrawCurve(pen, points);
        }

        private void checkBoxSmooth_CheckedChanged(object sender, EventArgs e)
        {
            canvas.Refresh();
            labelPanel.Refresh();
        }

        private void changeDataDisplayed()
        {
            if (listBoxModelHouses.SelectedItems.Count >= 0 && listBoxModelHouses.Items.Count > 0) listBoxModelHouses.SelectedIndex = 0;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            //basically see if we've had a change in the cache, if so, recalculate and redraw everything. List boxes, etc
            int currSum = 0;

            currSum += Cache.genListin.Count;
            currSum += Cache.genListOut.Count;
            currSum += Cache.houseModels.Count;
            currSum += Cache.availableTurbines.Count;
            currSum += Cache.windModel.getLength();
            currSum += Cache.currDay.getValue();
            string date = Cache.currDay.Day + "/" + Cache.currDay.Month + "/" + Cache.currDay.Year;
            currSum += (int)Cache.windModel.getDailySpeeds(date).Sum();


            if (currSum != cacheValue)
            {
                listBoxModelHouses.SelectedIndex = currHouseIndex;
                listBoxGenerators.SelectedIndex = currGenIndex;
                cacheValue = currSum;
                updateDate();
                if (listBoxGenerators.SelectedIndex != -1) recalculateGenTotals();
                updateLists();
                changeDataDisplayed();
                canvas.Refresh();
                labelPanel.Refresh();
                doDrawing();
            }
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            if (e.Button == MouseButtons.Left)
            {
                maxVal = maxVal * 2;
                canvas.Refresh();
                labelPanel.Refresh();
            }
            else if (e.Button == MouseButtons.Right)
            {
                maxVal = maxVal / 2;
                canvas.Refresh();
                labelPanel.Refresh();
            }
            */
        }

        public double GetPercentageOfDay(string time)
        {
            DateTime dateTime;
            if (!DateTime.TryParseExact(time, "HHmm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
            {
                throw new ArgumentException("Invalid time format, must be in 24-hour format: HHmm");
            }

            double totalSecondsInDay = TimeSpan.FromDays(1).TotalSeconds;
            double secondsElapsed = dateTime.TimeOfDay.TotalSeconds;
            double percentageOfDay = secondsElapsed / totalSecondsInDay * 100.0;

            return Math.Round(percentageOfDay, 2) / 100;
        }

        private void checkBoxDaylight_CheckedChanged(object sender, EventArgs e)
        {
            updateDate();
            canvas.Refresh();
            labelPanel.Refresh();
        }


        private void DrawSunlightGradient(Graphics canv, double sunrisePercent, double sunsetPercent)
        {
            // Define the colors and positions in the gradient
            Color[] gradientColors = new Color[]
            {
                Color.FromArgb(200,0, 0, 0),  // Midnight color
                Color.FromArgb(200,0, 0, 30),  // Night color
                Color.FromArgb(200,255,166,179),  // Sunrise color
                Color.FromArgb(200,135, 206, 235),  // Day color
                Color.FromArgb(200,239, 82, 0),  // Sunset color
                Color.FromArgb(200,0, 0, 30),  // Night color
                Color.FromArgb(200,0, 0, 0)  // Midnight color
            };

            float[] gradientPositions = new float[]
            {
                0.0f,  // Midnight color position
                (float)sunrisePercent - 0.1f,  // Night color position
                (float)sunrisePercent,  // Sunrise color position
                0.5f,  // Day color position
                (float)sunsetPercent,  // Sunset color position
                (float)sunsetPercent + 0.05f,  // Night color position
                1.0f  // Midnight color position
            };

            // Create a color blend object and set its colors and positions
            ColorBlend blend = new ColorBlend();
            blend.Colors = gradientColors;
            blend.Positions = gradientPositions;

            // Create a linear gradient brush with the blend
            LinearGradientBrush brush = new LinearGradientBrush(
                new PointF(0, 0),
                new PointF(canvas.Width, 0),
                Color.Black,
                Color.Black);
            brush.InterpolationColors = blend;

            // Fill the canvas with the gradient
            canv.FillRectangle(brush, 0, 0, canvas.Width, canvas.Height);
        }

        private void DailyForecast_Resize(object sender, EventArgs e)
        {
            canvas.Refresh();
            labelPanel.Refresh();
        }
    }
}