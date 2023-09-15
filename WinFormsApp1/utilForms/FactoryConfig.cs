using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using WinFormsApp1.Other_Form_Test;
using WinFormsApp1.utilForms;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class FactoryConfig : Form
    {

        FactoryModel snapshot = null;
        FactoryModel mainFactory = Cache.mainFactory;
        public FactoryConfig()
        {
            InitializeComponent();
            snapshot = Cache.mainFactory.Clone();

            // Init fields
            textBoxName.Text = mainFactory.Name;

            //init machineryList
            reloadMachines();

            openFileDialog1.Filter = "(csv files (*.csv)|*.csv";
        }

        public void reloadMachines()
        {
            listBoxMachines.Items.Clear();
            listBoxMachineTimes.Items.Clear();
            if (mainFactory.Machines.Count > 0)
            {
                foreach (Tuple<string, double> item in mainFactory.Machines)
                {
                    listBoxMachines.Items.Add(item.Item1);
                }
            }
            else
            {
                listBoxMachines.Items.Add("Factory has no machines yet!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cache.mainFactory = snapshot;
            this.Close();
        }

        private void listBoxMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear listbox
            listBoxMachineTimes.Items.Clear();
            if (listBoxMachines.SelectedIndex == -1) return;

            //List each time associated with machine
            //get name
            string machineName = (string)listBoxMachines.Items[listBoxMachines.SelectedIndex];
            //if that name exists in our dictionary
            if (mainFactory.MachineTimeRanges.ContainsKey(machineName))
            {
                //get the list of timespan tuples
                List<Tuple<TimeSpan, TimeSpan>> currTimes = mainFactory.MachineTimeRanges[machineName];

                //DEBUG
                // Console.WriteLine(currTimes.Count.ToString());

                //display each tuple in the listbox
                if (currTimes.Count > 0)
                {
                    foreach (Tuple<TimeSpan, TimeSpan> currTime in currTimes)
                    {
                        //Add to list
                        listBoxMachineTimes.Items.Add($"{currTime.Item1.ToString()} to {currTime.Item2.ToString()}");
                    }
                }
                else listBoxMachineTimes.Items.Add("There are no times for this machine yet.");
            }
            else
            {
                listBoxMachineTimes.Items.Add("This machine somehow does not exist??!! Sync Error.");
            }
        }

        private void buttonNewItem_Click(object sender, EventArgs e)
        {
            AddMachine f = new AddMachine();
            f.ShowDialog();
            reloadMachines();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxMachines.SelectedIndex == -1) return;
            string name = (string)listBoxMachines.Items[listBoxMachines.SelectedIndex];
            AddTimeRange t = new AddTimeRange(name);
            t.ShowDialog();
            reloadMachines();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Cache.mainFactory.Name = textBoxName.Text;
            this.Close();
        }

        private void buttonPreLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<double> load = new List<double>();
                    using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Process the line
                            string[] values = line.Split(',');
                            foreach (string value in values)
                            {
                                load.Add(double.Parse(value));
                            }
                        }
                    }
                    Cache.mainFactory.setVariableLoad(load);
                    MessageBox.Show("Pre=defined Load configured. Factory will use this to calculate daily load instead of Configured Machines.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The process failed for the following reasons: {ex}");
                }
            }
        }

        private void buttonClearImport_Click(object sender, EventArgs e)
        {
            Cache.mainFactory.clearVariableLoad();
            Cache.mainFactory.clearComprehensiveLoad();
        }

        private void buttonComp_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Cache.mainFactory.setComprehensiveLoad(fbd.SelectedPath);
                    panel2.Refresh();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (!mainFactory.UsesCompLoad) return;

            List<int> importCompletenessByMonth = CalculateImportCompletenessByMonth(mainFactory.CompLoadPath);
            Graphics g = e.Graphics;
            int width = panel2.Width;
            int height = panel2.Height;
            int barWidth = width / importCompletenessByMonth.Count;
            int maxHeight = height - 20; // Adjust this value to leave some space for labels or other elements

            // Draw the chart bars
            for (int i = 0; i < importCompletenessByMonth.Count; i++)
            {
                int barHeight = (int)(maxHeight * (importCompletenessByMonth[i] / 100.0));
                int x = i * barWidth;
                int y = height - barHeight;

                Rectangle barRect = new Rectangle(x, y, barWidth, barHeight);
                g.FillRectangle(Brushes.LightGreen, barRect); // Use any desired color or style

                // Optional: Draw labels or other relevant information
                // For example, you can draw the month below each bar
                string monthLabel = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(i + 1);
                SizeF labelSize = g.MeasureString(monthLabel, Font);
                float labelX = x + (barWidth - labelSize.Width) / 2;
                float labelY = height - labelSize.Height;
                g.DrawString(monthLabel, Font, Brushes.Black, labelX, labelY);
            }

            // Optional: Draw axes, labels, or other additional elements
            // For example, you can draw horizontal and vertical lines, axis labels, titles, etc.
        }

        List<int> CalculateImportCompletenessByMonth(string directoryPath)
        {
            int[] importCompleteness = new int[12];
            string[] files = Directory.GetFiles(directoryPath);

            foreach (string filePath in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string[] fileNameParts = fileName.Split('_');

                if (fileNameParts.Length == 4)
                {
                    if (int.TryParse(fileNameParts[1], out int month))
                    {
                        importCompleteness[month - 1]++;
                    }
                }
            }
            List<int> daysInMonth = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] buildingArray = new int[12];
            for (int m = 1; m <= 12; m++)
            {
                buildingArray[m - 1] = (importCompleteness[m - 1] / daysInMonth[m - 1]) * 100;
            }
            return buildingArray.ToList<int>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxMachines.SelectedIndex > -1)
            {
                mainFactory.Machines.RemoveAt(listBoxMachines.SelectedIndex);
            }
            reloadMachines();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxMachineTimes.SelectedIndex > -1)
            {
                if (listBoxMachines.SelectedIndex == -1) return;
                //get name
                string machineName = (string)listBoxMachines.Items[listBoxMachines.SelectedIndex];
                if (mainFactory.MachineTimeRanges.ContainsKey(machineName))
                {
                    mainFactory.MachineTimeRanges[machineName].RemoveAt(listBoxMachineTimes.SelectedIndex);
                }
                listBoxMachines_SelectedIndexChanged(null, null);
            }
        }
    }
}
