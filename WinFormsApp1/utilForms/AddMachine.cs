using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Other_Form_Test
{
    public partial class AddMachine : Form
    {
        public AddMachine()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int wattage = int.Parse(textBoxWattage.Text);
            Cache.mainFactory.AddMachine(name, wattage);
            MessageBox.Show($"Added machine: {name} with wattage: {wattage}");
            textBoxName.Text = "";
            textBoxWattage.Text = "";
        }
    }
}
