using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormsApp1.EnergyStorage;

namespace WinFormsApp1.Reporting
{
    internal class DayReport
    {
        List<Tuple<string, List<int>>> tupleList;
        string date;

        public double SolarPercent { get; set; }
        public double WindPercent { get; set; }
        public double OtherPercent { get; set; }

        public LithiumIonBattery GridCapacity { get; set; }

        public DayReport(string date)
        {
            tupleList = new List<Tuple<string, List<int>>>();
            this.date = date;
        }

        public List<Tuple<string, List<int>>> TupleList { get => tupleList; }

        public void InsertItem(string name, List<int> values)
        {
            Tuple<string, List<int>> tuple = new Tuple<string, List<int>>(name, values);
            tupleList.Add(tuple);
        }

        public Tuple<string, List<int>> RetrieveItem(string name)
        {
            Tuple<string, List<int>> tuple = tupleList.Find(t => t.Item1 == name);
            if (tuple != null)
            {
                return tuple;
            }
            else
            {
                return null;
            }
        }

        public string getSummary() {
            string prompt = $"Summary for {date}: ";
            foreach (Tuple<string, List<int>> tup in TupleList)
            {
                prompt += $", {tup.Item1}: {tup.Item2.Sum()} watts";
            }
            prompt += $", Solar Generation: {Math.Round(SolarPercent, 4) * 100}%";
            prompt += $", Wind Generation: {Math.Round(WindPercent, 4) * 100}%";


            return prompt;
        }
    }
}
