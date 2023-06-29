using MathNet.Numerics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Reporting;

namespace WinFormsApp1
{


    public partial class DailyReportViewer : Form
    {
        const int PADDING = 5;
        int maxVal = 1;
        Graphics g;
        Graphics gy;
        Graphics gx;
        DayReport currData = null;
        Font defaultFont = new Font("Arial", 10);
        SolidBrush stringBrush = new SolidBrush(Color.Black);
        StringFormat drawFormat = new StringFormat();
        Font drawFont = new Font("Arial", 10);
        Pen pen = new Pen(Color.Gray);
        string response = "Awaiting Responce...";
        string sk = "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";
        bool promptSent = false;

        public DailyReportViewer()
        {
            InitializeComponent();
            // Enable owner-drawing for the CheckedListBox
            checkedListBoxData.DrawMode = DrawMode.OwnerDrawVariable;
            drawFormat.FormatFlags = StringFormatFlags.NoWrap;

            //once form is initialized, call the main display report method
            g = mainCanvas.CreateGraphics();
            gy = panelY.CreateGraphics();
            gx = panelX.CreateGraphics();

            mainCanvas.Invalidate();
        }

        private async void process_report()
        {
            if (currData == null)
            {
                //retrieve data only if we do not have it.
                currData = DailyReporter.GenerateReport(Cache.currDay.getSunrise());
                //Setup CheckBoxes once
                drawCheckBoxes();

            }
            // ------ The following calculations should be integrated into the dailyreport.
            //BOXES
            //Generation Percent
            labelWindPercent.Text = $"{currData.getWindPercent()}%";
            labelSolarPercent.Text = $"{currData.getSolarPercent()}%";
            //In kWh
            int cleanEnergy = (int)currData.getCleanEnergy() / 1000;
            int emissionsEnergy = (int)currData.getEmissionEnergy() / 1000;
            int consumption = (int)currData.getConsumption() / 1000;
            double emissions = currData.getEmissions();
            string unit = " kWh";
            //Labels!!!
            labelCo2.Text = Math.Max(emissions, 0) + " kgCO2/MWh";
            labelDirty.Text = Math.Max(emissionsEnergy, 0) + unit;
            labelRenew.Text = cleanEnergy + unit;
            labelTotalConsumption.Text = consumption + unit;
            labelTotalStorage.Text = currData.GridCapacity.Capacity / 1000 + " kW";
            int net = (int)currData.getNet() / 1000;
            labelInternalNet.Text = net + unit;
            labelInternalNet.ForeColor = net > 0 ? Color.Red : net == 0 ? Color.Gold : Color.Green;
            decimal setup = Cache.getSetupCost();
            //Cost Analysis
            // Hamilton	21.2c
            labelEffCost.Text = "$" + currData.getEffectiveCost();
            labelGridCost.Text = "$" + currData.getGridCost();
            labelSaved.Text = "$" + currData.getNegatedGridCost();
            labelSetupCost.Text = "$" + setup;
            labelBuyBack.Text = "$" + currData.getGridBuyBack();
            double daysTillPayDone = (int)(setup / (currData.getDaySavings()));
            //double daysTillPayDone = (int)(setup / (currData.getGenSavings() + currData.getGridBuyBack()));
            string time = daysTillPayDone > 183 ? "Years" : daysTillPayDone > 365 ? "Months" : "Days";
            daysTillPayDone = daysTillPayDone > 365 ? daysTillPayDone / 365 : daysTillPayDone > 183 ? daysTillPayDone / 30 : daysTillPayDone;
            labelPayback.Text = $"{Math.Round(daysTillPayDone, 2)} {time}";
            if (!promptSent)
            {
                promptSent = true;
                //Get GPT Report
                string prompt = currData.getSummary();
                prompt = "Analyze and comment on interesting values in the following totals. Its a day of power usage. " +
                    "There is not reason to explain what the totals represent, that is implied. " +
                    "Include in your response only the report, and nothing else. Try not to repeat yourself." + prompt + $"{emissions} kgCO2/kWh today.";
                Console.WriteLine(prompt);
                //await sendRequest(prompt);
            }

            List<int> contenders = new List<int>();
            foreach (var checkedItem in checkedListBoxData.CheckedItems)
            {
                contenders.Add(currData.RetrieveItem(checkedItem.ToString()).Item2.Max());
            }
            maxVal = contenders.Count > 0 ? contenders.Max() : 1;

            panelY.Invalidate();
            panelX.Invalidate();

            //vert lines
            for (int j = 0; j < mainCanvas.Width; j = j + mainCanvas.Width / 24)
            {
                g.DrawLine(pen, j, mainCanvas.Height, j, 0);

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
                        g.DrawLine(pen, 0, yVal, mainCanvas.Width, yVal);
                    }
                }
            }

            pen.Width = 1;
            pen.Color = Color.Gray;

            //borders
            g.DrawLine(pen, 1, mainCanvas.Height, 1, 1);
            g.DrawLine(pen, 1, mainCanvas.Height - 1, mainCanvas.Width, mainCanvas.Height - 1);
            g.DrawLine(pen, 1, 1, mainCanvas.Width, 1);
            g.DrawLine(pen, mainCanvas.Width - 1, 0, mainCanvas.Width - 1, mainCanvas.Height);
            int i = 0;
            int y = 10;
            Color[] colors = new Color[] { Color.Green, Color.Red, Color.Blue, Color.Orange, Color.Olive, Color.Gray, Color.Gold };

            //Put all da data
            foreach (var checkedItem in checkedListBoxData.CheckedItems)
            {
                stringBrush.Color = colors[i % colors.Length];
                //Draw the string at the top of the screen, 10 pixel offset both x and y to begin with
                g.DrawString("---- " + checkedItem.ToString(), new Font("Arial", 10), stringBrush, 10, y);
                put_data(currData.RetrieveItem(checkedItem.ToString()).Item2, mainCanvas, colors[i], 3);
                //offset y by 15 px
                y += 15;
                i++;
            }
        }

        private void drawCheckBoxes()
        {
            checkedListBoxData.Items.Clear();
            List<Tuple<string, List<int>>> allLists = currData.TupleList;
            foreach (var tuple in allLists)
            {
                checkedListBoxData.Items.Add(tuple.Item1);
            }
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
                int tayloredHeight = height < 0 ? 0 : height;
                x += xInc;
                y = targetCanvas.Height - (int)(workingHeight * tayloredHeight / maxVal);
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

        private void panelX_Paint(object sender, PaintEventArgs e)
        {
            gx = panelX.CreateGraphics();
            int workingWidth = panelX.Width - panelY.Width;
            int xTarre = panelY.Width;
            int points = 48;
            int xInc = workingWidth / points;
            int y = panelX.Height / 2;
            string currTime = "00:00";
            int hour = 0;
            int minute = 0;
            stringBrush.Color = Color.Black;
            int increment = workingWidth < 350 ? 12 : 4;
            increment = workingWidth > 1200 ? 2 : increment;

            for (int i = 0; i < points; i++)
            {
                if (i % increment == 0) gx.DrawString(currTime, drawFont, stringBrush, xTarre - 13, y);
                xTarre += xInc;
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
            gy = panelY.CreateGraphics();
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

        private void mainCanvas_Resize(object sender, EventArgs e)
        {
            mainCanvas.Invalidate();
        }

        private void checkedListBoxData_Click(object sender, EventArgs e)
        {
            mainCanvas.Invalidate();
        }

        //GPT Ai Stuff

        public async Task sendRequest(string request)
        {
            string endpoint = "https://api.openai.com/v1/chat/completions";

            var messages = new[]
            {
                new { role = "user", content = request }
            };

            var data = new
            {
                model = "gpt-3.5-turbo",
                messages = messages,
                temperature = 0.7
            };

            string jsonString = JsonConvert.SerializeObject(data);

            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {sk}");

            var initResponce = await client.PostAsync(endpoint, content);

            string responseContent = await initResponce.Content.ReadAsStringAsync();

            var jsonResponce = JObject.Parse(responseContent);
            try
            {
                response = jsonResponce["choices"][0]["message"]["content"].Value<string>();
            }
            catch
            {
                response = "There was an issue communicating with ChatGPT-3.5-turbo. ";
            }
            writeResponse();
        }

        private void writeResponse()
        {
            richTextBoxResponce.Clear();
            richTextBoxResponce.Text = response;
        }

    }
}
