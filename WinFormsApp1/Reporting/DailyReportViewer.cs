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
        string response = "Awaiting Responce...";

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

                //Get GPT Report
                string prompt = currData.getSummary();
                prompt = "Write me a report on the following totals about a day of power data, and comment on interesting values. " +
                    "There is not reason to explain what the totals represent, that is implied. " +
                    "Include in your response only the report, and nothing else. Try not to repeat yourself." + prompt;
                Console.WriteLine(prompt);
                await sendRequest(prompt);
            }
            List<int> contenders = new List<int>();
            foreach (var checkedItem in checkedListBoxData.CheckedItems)
            {
                contenders.Add(currData.RetrieveItem(checkedItem.ToString()).Item2.Max());
            }
            maxVal = contenders.Count > 0 ? contenders.Max() : 1;

            panelY.Invalidate();
            //drawXAxis();
            //drawBorder();
            //Calculate the MaxValue
            //Draw!
            int i = 0;
            int y = 10;
            Color[] colors = new Color[] { Color.Green, Color.Red, Color.Blue, Color.Orange, Color.Olive, Color.Gray, Color.Gold };
            foreach (var checkedItem in checkedListBoxData.CheckedItems)
            {
                stringBrush.Color = colors[i];
                //Draw the string at the top of the screen, 10 pixel offset both x and y to begin with
                g.DrawString("--- " + checkedItem.ToString(), new Font("Arial", 10), stringBrush, 10, y);
                put_data(currData.RetrieveItem(checkedItem.ToString()).Item2, mainCanvas, colors[i], 3);
                //offset y by 15 px
                y += 15;
                i++;

            }
        }

        private void drawBorder()
        {
            throw new NotImplementedException();
        }

        private void drawXAxis()
        {
            throw new NotImplementedException();
        }

        private void drawYAxis(int largestValue)
        {
            int intervals = 10;
            int roundingTo = 1000;
            int y = panelY.Height;
            int x = panelY.Width;
            int yPxIncrement = panelY.Height / intervals;
            //Round up largest value to nearest thousand
            int roundedVal = (largestValue - (largestValue % 1000)) + 1000;
            int yValIncrement = roundedVal / intervals;
            Pen p = new Pen(Color.Black);

            for (int i = 1; i <= intervals; i++)
            {
                stringBrush.Color = Color.Black;
                gy.DrawLine(p, x, y, x-10, y);
                gy.DrawString(i * yValIncrement + "", drawFont, stringBrush, 0, y);
                y -= yPxIncrement;
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
                        int strX = xVal - (int)strSize.Width;
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
                //new { role = "user", content = request }
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

            client.DefaultRequestHeaders.Add("Authorization", "Bearer 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");

            var initResponce = await client.PostAsync(endpoint, content);

            string responseContent = await initResponce.Content.ReadAsStringAsync();

            var jsonResponce = JObject.Parse(responseContent);

            response = jsonResponce["choices"][0]["message"]["content"].Value<string>();

            writeResponse();
        }

        private void writeResponse()
        {
            richTextBoxResponce.Clear();
            richTextBoxResponce.Text = response;
        }

    }
}
