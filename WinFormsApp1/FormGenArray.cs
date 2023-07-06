using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Solar;

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
                textBoxW.Text = "1.651m x 0.9906m";
                textBoxWatts.Text = "250";
                textBoxCells.Text = "60";
                textBoxPrice.Text = int.Parse(textBoxWatts.Text) * 2.5 + "";
            }
            else if (comboBoxSolarType.SelectedIndex == 1)
            {
                textBoxMat.Text = "Polycrystalline";
                textBoxW.Text = "1.9812m x 0.9906m";
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
                    SolarPanelArray s = new SolarPanelArray(material, width, length, watts, cells, material, amount, price);
                    Cache.genListin.Add(s);
                    MessageBox.Show("Successfully Created Soloar Panel Array of " + amount + " panel(s).");
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
    }
}
