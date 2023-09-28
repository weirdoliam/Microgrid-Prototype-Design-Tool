using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.utilForms
{
    public partial class ChangePriceOfPower : Form
    {
        public ChangePriceOfPower()
        {
            InitializeComponent();
            textBoxPrice.Text = (Cache.powerCost * 100) + "";
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            try
            {
                double newCost = double.Parse(textBoxPrice.Text) / 100;
                MessageBox.Show($"Price updated to ${newCost} per kWh");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number");
            }
        }
    }
}
