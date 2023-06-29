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
                //new SolarPanel("Residential", 1.651f, 0.9906f, 345, 60, "Monocrystalline");
                labelDim.Text = "Dimensions: 1.651m x 0.9906m";
                labelMat.Text = "Material: Monocrystalline";
                labelWatts.Text = "Watts: 250 W";
            }
            else if (comboBoxSolarType.SelectedIndex == 1)
            {
                //new SolarPanel("Commercial", 1.9812f, 0.9906f, 345, 72, "Polycrystalline");
                labelDim.Text = "Dimensions: 1.9812m x 0.9906m";
                labelWatts.Text = "Watts: 345W";
                labelMat.Text = "Material: Polycrystalline";
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
                if (comboBoxSolarType.SelectedIndex == 0)
                {
                    SolarPanelArray s = new SolarPanelArray("Residential", 1.651f, 0.9906f, 250, 60, "Monocrystalline", amount);
                    Cache.genListin.Add(s);
                    MessageBox.Show("Successfully Created Residential Soloar Panel Array of " + amount + " panel(s).");
                }
                else if (comboBoxSolarType.SelectedIndex == 1)
                {
                    SolarPanelArray s = new SolarPanelArray("Commercial", 1.9812f, 0.9906f, 345, 72, "Polycrystalline", amount);
                    Cache.genListin.Add(s);
                    //MessageBox.Show("Successfully Created Commercial Soloar Panel Array of " + amount + " panel(s).");
                }
                this.Close();
            }
            else {
                MessageBox.Show("Please install at least 1 unit.");
            }
        }

        private void comboBoxWindType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
