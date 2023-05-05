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
        int maxVal = 2000;
        const int PADDING = 5;
        string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        bool overlayFactoryLoad = false;
        List<double> factoryHeights = Cache.mainFactory.GetHourlyConsumptionList();

        public DailyForecast()
        {
            InitializeComponent();

            drawFormat.FormatFlags = StringFormatFlags.NoWrap;
            radioButtonOne.Checked = true;
        }

        //updateListBoxes
        private void updateLists()
        {
            listBoxModelHouses.Items.Clear();
            listBoxGenerators.Items.Clear();
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
        }

        private void listBoxModelHouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!radioButtonAll.Checked)
            {
                if (Cache.genListOut[listBoxModelHouses.SelectedIndex] is HouseModel)
                {
                    currHouseIndex = listBoxModelHouses.SelectedIndex;
                    currHouse = (HouseModel)Cache.genListOut[listBoxModelHouses.SelectedIndex];
                    List<int> dailyData = currHouse.getDailyData(Cache.currDay.Day + "/" + Cache.currDay.Month + "/" + Cache.currDay.Year);
                    canvas.Refresh();
                    labelPanel.Refresh();
                }
            }
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
            List<int> homeHeights;
            //average heights
            if (checkBoxAverage.Checked == true)
            {
                homeHeights = currHouse.getAverageDailyData();
            }

            else homeHeights = currHouse.getDailyData(Cache.currDay.Day + "/" + Cache.currDay.Month + "/" + Cache.currDay.Year);
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

            if (!radioButtonAll.Checked)
            {
                canvas.Refresh();
                labelPanel.Refresh();
            }
        }

        private void DailyForecast_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// redraws every seccond
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paintTimer_Tick(object sender, EventArgs e)
        {

        }

        private void doDrawing()
        {
            doDrawing(1);
        }

        private void doDrawing(double multiple)
        {
            int consume = 0;
            int gen = 0;

            if (currHouse == null)
            {
                return;
            }
            //graph detail

            //vert lines
            pen.Color = Color.LightGray;
            for (int i = 0; i < canvas.Width; i = i + canvas.Width / 24)
            {
                g.DrawLine(pen, i, canvas.Height, i, 0);

            }

            //horiz lines
            double scale = Math.Floor(maxVal / 50.0) * 5;
            if (maxVal > 10000) scale = Math.Floor(maxVal / 100.0) * 10;

            if (maxVal > 1000000) scale = Math.Floor(maxVal / 100000.0) * 10000;

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
            //labels
            // Set format of string.

            //borders
            g.DrawLine(pen, 0, canvas.Height, 0, 0);
            g.DrawLine(pen, 0, canvas.Height - 1, canvas.Width, canvas.Height - 1);


            if (listBoxModelHouses.SelectedIndex != -1)
            {
                List<int> homeHeights;
                pen.Width = 2;
                pen.Color = Color.Crimson;
                int xInc = canvas.Width / 48;
                int x = 0;
                int y = 0;
                int workingHeight = canvas.Height - (int)(canvas.Height * 0.1);

                //average heights
                if (checkBoxAverage.Checked == true)
                {
                    homeHeights = currHouse.getAverageDailyData();
                }

                else homeHeights = currHouse.getDailyData(Cache.currDay.Day + "/" + Cache.currDay.Month + "/" + Cache.currDay.Year);


                //display what is in heights
                if (homeHeights != null)
                {

                    //round up to the nearest 500
                    int localmaxVal = 500 * (int)Math.Round((decimal)(maxVal / 500));
                    //if (localmaxVal < 2000) maxVal = 2000;
                    if (localmaxVal <= maxVal) maxVal += 500;
                    //*/

                    Point[] points = new Point[homeHeights.Count + 1];
                    points[0] = new Point(x, canvas.Height - workingHeight * (homeHeights[0] / maxVal));
                    //actual data
                    int prevX = x;
                    int prevY = canvas.Height - (int)workingHeight * (homeHeights[0] / maxVal);
                    int index = 1;

                    foreach (int height in homeHeights)
                    {
                        x += xInc;
                        y = canvas.Height - (int)(workingHeight * height / maxVal);
                        if (!checkBoxSmooth.Checked) g.DrawLine(pen, prevX, prevY - PADDING, x, y - PADDING);
                        prevX = x;
                        prevY = y;
                        points[index] = new Point(x, y - PADDING);
                        index++;
                        consume += height;
                    }
                    if (checkBoxSmooth.Checked) g.DrawCurve(pen, points);

                    if (!radioButtonAll.Checked)
                    {
                        //Display Data in boxes;
                        fillRect(panelElectric, currHouse.getElectricPercent());
                        fillRect(panelMains, currHouse.getMainsPercent());
                        fillRect(panelOther, currHouse.getOtherPercent());
                        //consumption
                        labelAverageDaily.Text = currHouse.getDailyConsumption() + " kWh";
                    }
                    else
                    {
                        fillRect(panelElectric, currHouse.AverageElectric);
                        fillRect(panelMains, currHouse.AverageMains);
                        fillRect(panelOther, currHouse.AverageOther);
                        //consumption
                        labelAverageDaily.Text = currHouse.getDailyConsumption() + " kWh";
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
                pen.Width = 2;
                pen.Color = Color.Green;
                int xInc = canvas.Width / 48;
                int x = 0;
                int y = 0;
                int workingHeight = canvas.Height - (int)(canvas.Height * 0.1);

                Point[] points = new Point[genHeights.Count + 1];
                points[0] = new Point(x, canvas.Height - (int)workingHeight * (genHeights[0] / maxVal));

                //actual data
                int prevX = x;
                int prevY = canvas.Height - (int)workingHeight * (genHeights[0] / maxVal);
                int index = 1;

                foreach (int height in genHeights)
                {
                    x += xInc;
                    y = canvas.Height - (int)(workingHeight * height / maxVal);
                    if (!checkBoxSmooth.Checked)
                    {
                        //MessageBox.Show("x: " + x + ", y: " + y + ", prevX: " + prevX + ", prevY: " + prevY);
                        g.DrawLine(pen, prevX, prevY - PADDING, x, y - PADDING);
                    }
                    prevX = x;
                    prevY = y;
                    points[index] = new Point(x, y - PADDING);
                    index++;
                    gen += height;
                }
                if (checkBoxSmooth.Checked) g.DrawCurve(pen, points);
                
            }

            //display what is in heights
            if (overlayFactoryLoad)
            {
                //get the factory load profile
                List<double> factoryHeights = Cache.mainFactory.GetHourlyConsumptionList();

                //ok now display!
                pen.Width = 2;
                pen.Color = Color.Yellow;
                int xInc = canvas.Width / 48;
                int x = 0;
                int y = 0;
                int workingHeight = canvas.Height - (int)(canvas.Height * 0.1);

                Point[] points = new Point[factoryHeights.Count + 1];
                points[0] = new Point(x, canvas.Height - workingHeight * (int)(factoryHeights[0] / maxVal));

                //actual data
                int prevX = x;
                int prevY = canvas.Height - workingHeight * (int)(factoryHeights[0] / maxVal);
                int index = 1;

                foreach (int height in factoryHeights)
                {
                    x += xInc;
                    y = canvas.Height - (int)(workingHeight * height / maxVal);
                    if (!checkBoxSmooth.Checked)
                    {
                        //MessageBox.Show("x: " + x + ", y: " + y + ", prevX: " + prevX + ", prevY: " + prevY);
                        g.DrawLine(pen, prevX, prevY - PADDING, x, y - PADDING);
                    }
                    prevX = x;
                    prevY = y;
                    points[index] = new Point(x, y - PADDING);
                    index++;
                    consume += height;
                }
                if (checkBoxSmooth.Checked) g.DrawCurve(pen, points);
            }
            labelGenerate.Text = gen + " W";
            labelConsume.Text = consume + " W";
            int net = gen - consume;
            labelNet.Text = net + " W";
            if (net < 0 ) { labelNet.ForeColor = Color.Red; }
            else { labelNet.ForeColor = Color.Green;}
        }

        private void fillRect(Panel p, double percent)
        {
            box = p.CreateGraphics();
            brush.Color = Color.DarkGray;
            box.FillRectangle(brush, new Rectangle(0, 0, p.Width, p.Height));
            brush.Color = Color.Crimson;
            box.FillRectangle(brush, new Rectangle(0, 0, (int)(p.Width * percent), p.Height));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = canvas.CreateGraphics();
            doDrawing();
        }

        private void checkBoxAverage_CheckedChanged(object sender, EventArgs e)
        {
            canvas.Refresh();
            labelPanel.Refresh();
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

        private void checkBoxSmooth_CheckedChanged(object sender, EventArgs e)
        {
            canvas.Refresh();
            labelPanel.Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            changeDataDisplayed();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAverage.Checked = false;
            changeDataDisplayed();
        }

        private void changeDataDisplayed()
        {
            bool allHouses = radioButtonAll.Checked;

            if (allHouses)
            {
                double electricPercentAverage = 0;
                double gasPercentAverage = 0;
                double otherPercentAverage = 0;
                bool missingDataFlag = false;
                //For the CURRENT DAY
                int[] totalHeights = new int[48];

                foreach (EnergyOut h in Cache.genListOut)
                {
                    if (h is HouseModel)
                    {
                        HouseModel houseModel = (HouseModel)h;
                        //average each thing for the boxes
                        electricPercentAverage += houseModel.getElectricPercent();
                        gasPercentAverage += houseModel.getMainsPercent();
                        otherPercentAverage += houseModel.getOtherPercent();

                        //CURRENT DATE
                        List<int> currentDayHeights = houseModel.getDailyData(Cache.currDay.Day + "/" + Cache.currDay.Month + "/" + Cache.currDay.Year);
                        if (currentDayHeights == null)
                        {
                            missingDataFlag = true;
                        }
                        else
                        {
                            try
                            {
                                for (int i = 0; i < totalHeights.Length; i++)
                                {
                                    totalHeights[i] += currentDayHeights[i];
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.ToString());
                                Console.WriteLine("[ERROR]: Some missing data was skipped when totalling daily consumption.");
                            }
                        }
                    }
                }
                if (missingDataFlag)
                {
                    labelMissingData.Text = "! Some Data is missing in these totals !";
                }
                else
                {
                    labelMissingData.Text = "";
                }

                currHouse = new HouseModel(true);
                currHouse.putDay(Cache.currDay.Day + "/" + Cache.currDay.Month + "/" + Cache.currDay.Year, totalHeights.ToList<int>());

                electricPercentAverage = electricPercentAverage / Cache.houseModels.Count;
                gasPercentAverage = gasPercentAverage / Cache.houseModels.Count;
                otherPercentAverage = otherPercentAverage / Cache.houseModels.Count;

                currHouse.AverageElectric = electricPercentAverage;
                currHouse.AverageMains = gasPercentAverage;
                currHouse.AverageOther = otherPercentAverage;


            }
            else if (!allHouses)
            {
                if (listBoxModelHouses.SelectedItems.Count >= 0 && listBoxModelHouses.Items.Count > 0) listBoxModelHouses.SelectedIndex = 0;
            }
            canvas.Refresh();
            labelPanel.Refresh();
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
                cacheValue = currSum;
                updateDate();
                updateLists();
                changeDataDisplayed();
                if (listBoxGenerators.SelectedIndex != -1) recalculateGenTotals();
                doDrawing();
                listBoxModelHouses.SelectedIndex = currHouseIndex;
                listBoxGenerators.SelectedIndex = currGenIndex;
            }
        }

        private void checkBoxFactoyLoad_CheckedChanged(object sender, EventArgs e)
        {
            overlayFactoryLoad = checkBoxFactoyLoad.Checked;
            canvas.Refresh();
            labelPanel.Refresh();
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
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
        }
    }
}