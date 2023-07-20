using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.EnergyStorage
{
    public partial class AddBattery : Form
    {
        public AddBattery()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(textBoxQuantity.Text);
            if (amount <= 0) { MessageBox.Show("Please specify quantity > 0"); return; }
            try
            {
                int cap = int.Parse(textBoxCap.Text);
                int volt = int.Parse(textBoxVoltage.Text);
                int liftcycle = int.Parse(textBoxLife.Text);
                int current = int.Parse(textBoxCurrent.Text);

                int Wh = current * volt;
                int ct = cap / Wh;
                decimal price = int.Parse(textBoxPrice.Text);
                int chargeRate = Wh / 2;
                for (int i = 0; i < amount; i++)
                {
                    LithiumIonBattery lib = new LithiumIonBattery(cap, chargeRate, comboBoxType.Text, price);
                    Cache.energyStorageUnits.Add(lib);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Populate text boxes on form
        /// </summary>
        /// <param name="cap">Capacity of battery W</param>
        /// <param name="volt">Voltage V</param>
        /// <param name="liftcycle">Warrantee Months</param>
        /// <param name="current">Amps</param>
        /// <param name="price">In NZD</param>
        /// <param name="chargeTime">in Hours</param>
        private void populateBoxes(int cap, int volt, int liftcycle, int current, decimal price)
        {
            textBoxCap.Text = cap + "";
            textBoxVoltage.Text = volt + "";
            textBoxLife.Text = liftcycle + "";
            textBoxCurrent.Text = current + "";
            int Wh = current * volt;
            int ct = cap / Wh;
            labelCharTime.Text = ct + " h";
            textBoxPrice.Text = price + "";
            labelkWh.Text = Math.Round((double)Wh / 1000, 2) + "";
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                populateBoxes(3000, 48, 96, 60, 999);
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                populateBoxes(5000, 48, 120, 120, 1499);
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                populateBoxes(6000, 48, 144, 120, 1799);
            }
            else
            {
                populateBoxes(500, 12, 12, 30, 300);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void calulateTotals()
        {
            try
            {
                int cap = int.Parse(textBoxCap.Text);
                int volt = int.Parse(textBoxVoltage.Text);
                int current = int.Parse(textBoxCurrent.Text);
                int Wh = current * volt;
                int ct = cap / Wh;
                labelCharTime.Text = ct + " h";
                labelkWh.Text = Math.Round((double)Wh / 1000, 2) + "";
            }
            catch
            {
                labelCharTime.Text = "Err h";
                labelkWh.Text = "Err kWh";
            }
        }

        private void textBoxCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            calulateTotals();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxVoltage_KeyPress(object sender, KeyPressEventArgs e)
        {
            calulateTotals();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCurrent_KeyPress(object sender, KeyPressEventArgs e)
        {
            calulateTotals();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
