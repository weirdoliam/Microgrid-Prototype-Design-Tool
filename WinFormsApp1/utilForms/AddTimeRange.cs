using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.utilForms
{
    public partial class AddTimeRange : Form
    {
        string _name;
        public AddTimeRange(string name)
        {
            InitializeComponent();
            _name = name;
            labelMachine.Text = _name;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int fr = int.Parse(from.Text);
            int t = int.Parse(to.Text);
            if (fr < 24 && t < 24 && fr < t)
            {
                Cache.mainFactory.AddMachineTimeRange(_name, new TimeSpan(fr, 0, 0), new TimeSpan(t, 0, 0));
                MessageBox.Show("Success!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Time range!");
            }
        }
    }
}
