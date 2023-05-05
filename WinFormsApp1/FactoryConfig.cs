using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Other_Form_Test;
using WinFormsApp1.utilForms;

namespace WinFormsApp1
{
    public partial class FactoryConfig : Form
    {

        DairyFactory snapshot = null;
        DairyFactory mainFactory = Cache.mainFactory;
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

        public void reloadMachines() {
            listBoxMachines.Items.Clear();
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
            if (mainFactory.MachineTimeRanges.ContainsKey(machineName)){
                //get the list of timespan tuples
                List<Tuple<TimeSpan, TimeSpan>> currTimes = mainFactory.MachineTimeRanges[machineName];
                
                //DEBUG
                Console.WriteLine(currTimes.Count.ToString());
                
                //display each tuple in the listbox
                if (currTimes.Count > 0)
                {
                    foreach (Tuple<TimeSpan, TimeSpan> currTime in currTimes)
                    {
                        //Add to list
                        listBoxMachineTimes.Items.Add($"{currTime.Item1.ToString()} - {currTime.Item2.ToString()}");
                    }
                }
                else listBoxMachineTimes.Items.Add("There are no times for this machine yet.");
            }
            else
            {
                listBoxMachineTimes.Items.Add("This machine somehow does not exist??!!");
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
        }
    }
}
