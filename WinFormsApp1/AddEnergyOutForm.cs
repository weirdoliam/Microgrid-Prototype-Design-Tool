using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddEnergyOutForm : Form
    {
        public AddEnergyOutForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            HouseModel newHouse = getHouseModel();
            if (newHouse == null) return;
            //now find some data that best fits this description
            List<int> scores = new List<int>();
            foreach (HouseModel h in Cache.houseModels)
            {
                scores.Add(newHouse.CalculateSimilarityScore(h));
            }
            //Figure out which house is closest
            int maxIndex = 0;
            int maxValue = scores[0];

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] > maxValue)
                {
                    maxIndex = i;
                    maxValue = scores[i];
                }
            }

            newHouse.consumptionData = Cache.houseModels[maxIndex].consumptionData;
            Cache.genListOut.Add(newHouse);
            MessageBox.Show("House model setup with load auto-selected.");

        }

        private HouseModel getHouseModel() {

            HouseModel newHouse;
            try
            {
                bool heatpump = checkedLBHM.GetItemChecked(0);
                bool ckElectric = checkedLBHM.GetItemChecked(1);
                bool ckMains = checkedLBHM.GetItemChecked(2);
                bool ckBottle = checkedLBHM.GetItemChecked(3);
                bool whElectric = checkedLBHM.GetItemChecked(4);
                bool whMains = checkedLBHM.GetItemChecked(5);
                bool whWood = checkedLBHM.GetItemChecked(6);
                bool shElectric = checkedLBHM.GetItemChecked(7);
                bool shMains = checkedLBHM.GetItemChecked(8);
                bool shWood = checkedLBHM.GetItemChecked(9);
                bool shFossil = checkedLBHM.GetItemChecked(10);

                int adults = (int)numericUpDownAdults.Value;
                int children = (int)numericUpDownChildren.Value;
                string location = textBoxLocation.Text;
                string income = textBoxIncome.Text + "k";

                newHouse = new HouseModel(heatpump,
                    ckElectric, ckMains, ckBottle,
                    whElectric, whMains, whWood,
                    shElectric, shMains, shWood, shFossil,
                    adults, children, income, location);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"You've Entered some data incorrectly. Please check and try again.\n Digest:\n {ex.Message}");
                return null;
            }
            return newHouse;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HouseModel newHouse = getHouseModel();
            if (newHouse == null) return;
            if (openFileDialogHouse.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialogHouse.FileName;
                MessageBox.Show(path);
                int points = 0;
                using (var reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string val = reader.ReadLine();
                        string[] values = val.Split(',');
                        //MessageBox.Show(values[0] + ", " + values[1]);
                        if (values.Length == 2 || values.Length == 3)
                        {
                            try
                            {
                                string[] isolatedDate = values[0].Split(' ');
                                //reformat to day month year
                                string[] newDateFormat = isolatedDate[0].Split("/");
                                //MessageBox.Show(newDateFormat[0]);
                                int year = 2022;
                                int month = int.Parse(newDateFormat[1]);
                                int day = int.Parse(newDateFormat[2]);
                                string date = day + "/" + month + "/" + year;
                                //MessageBox.Show(date);
                                newHouse.addTimeSample(date, (int)double.Parse(values[1]));
                                points++;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"HouseModel: Datam skipped due to error: {val}");
                            }
                        }
                        else
                        {
                            //skip
                            Console.WriteLine($"HouseModel: Datam not readable: {val}");
                        }
                    }
                }
                Cache.genListOut.Add(newHouse);
                MessageBox.Show($"House model setup with {points} data points read into load.");
            }
        }
    }
}
