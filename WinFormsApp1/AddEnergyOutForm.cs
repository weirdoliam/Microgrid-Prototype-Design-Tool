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

        private void button1_Click(object sender, EventArgs e)
        {
            Cache.genListOut.Add(new HouseArray((int)numericUpDown1.Value));
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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
            string location = comboBox1.SelectedItem.ToString();
            string income = textBoxIncome.Text + "k";

            HouseModel h = new HouseModel(heatpump, 
                ckElectric, ckMains, ckBottle, 
                whElectric, whMains, whWood, 
                shElectric, shMains, shWood, shFossil, 
                adults, children, income, location);
            //now find some data that best fits this description


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "house\\");
            string[] paths = Directory.GetFiles(path);

            for (int i = 0; i < paths.Length; i++)
            {
                using (var reader = new StreamReader(paths[i]))
                {
                    //parse the initial description
                    string[] d = reader.ReadLine().Split(',');
                    HouseModel newHouse = new HouseModel(bool.Parse(d[0]), bool.Parse(d[1]), bool.Parse(d[2]),
                        bool.Parse(d[3]), bool.Parse(d[4]), bool.Parse(d[5]), bool.Parse(d[6]), bool.Parse(d[7]), bool.Parse(d[8]),
                        bool.Parse(d[9]), bool.Parse(d[10]), int.Parse(d[11]), int.Parse(d[12]), d[13], d[14]);
                    //MessageBox.Show("Created House: " + newHouse.ToString());
                    while (!reader.EndOfStream)
                    {

                        string[] values = reader.ReadLine().Split(',');
                        //MessageBox.Show(values[0] + ", " + values[1]);
                        if (values.Length != 2)
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
                        }
                        else
                        {
                            //skip
                        }

                    }
                    Cache.houseModels.Add(newHouse);
                }
            }
            this.Close();
        }
    }
}
