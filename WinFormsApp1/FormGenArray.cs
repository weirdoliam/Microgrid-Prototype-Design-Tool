using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Solar;
using WinFormsApp1.Wind;

namespace WinFormsApp1
{
    public partial class FormGenArray : Form
    {
        public FormGenArray()
        {
            InitializeComponent();
        }

        private void comboBoxSolarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSolarType.SelectedIndex == 0)
            {
                textBoxMat.Text = "Monocrystalline";
                textBoxW.Text = "1.651";
                textBoxL.Text = "0.9906";
                textBoxWatts.Text = "250";
                textBoxCells.Text = "60";
                textBoxPrice.Text = int.Parse(textBoxWatts.Text) * 2.5 + "";
            }
            else if (comboBoxSolarType.SelectedIndex == 1)
            {
                textBoxMat.Text = "Polycrystalline";
                textBoxW.Text = "1.9812";
                textBoxL.Text = "0.9906";
                textBoxWatts.Text = "345";
                textBoxCells.Text = "72";
                textBoxPrice.Text = int.Parse(textBoxWatts.Text) * 2.5 + "";
            }
        }

        /// <summary>
        /// SOLAR PANEL BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(textBoxQuantity.Text.ToString());

            if (amount > 0)
            {
                try
                {
                    string material = textBoxMat.Text;
                    float width = float.Parse(textBoxW.Text);
                    float length = float.Parse(textBoxW.Text);
                    int watts = int.Parse(textBoxWatts.Text);
                    decimal price = decimal.Parse(textBoxPrice.Text);
                    int cells = int.Parse(textBoxCells.Text);
                    int hours = int.Parse(textBoxHours.Text);
                    SolarPanelArray s = new SolarPanelArray(material, width, length, watts, cells, material, amount, price, hours);
                    Cache.genListin.Add(s);
                    MessageBox.Show("Successfully Created Solar Panel Array of " + amount + " panel(s).");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please install at least 1 unit.");
            }
        }

        private void comboBoxWindType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(quantity.Text.ToString());
            int i = 0;
            if (amount > 0)
            {
                try
                {
                    for (i = 0; i < amount; i++)
                    {
                        WindTurbineExisting w = new WindTurbineExisting(name.Text, manu.Text, int.Parse(power.Text) * 1000, double.Parse(rotord.Text), double.Parse(sweptarea.Text), int.Parse(blades.Text), double.Parse(cutoutspeed.Text), double.Parse(ratedspeed.Text), double.Parse(cutin.Text));
                        w.Price = decimal.Parse(price.Text);
                        Cache.genListin.Add(w);
                    }
                    MessageBox.Show($"Successfully Created {amount} Windturbine(s)");
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error Creating panels after creating: {i}. Message: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please install at least 1 unit.");
            }
        }
    }
}
