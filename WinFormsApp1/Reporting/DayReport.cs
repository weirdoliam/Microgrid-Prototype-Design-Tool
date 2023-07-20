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
        public string Date { get; set; }
        //Emissions Factor
        private double emissionEmissonFactor = 0.025;
        private double cleanEmissionFactor = 0;
        public double SolarPercent { get; set; }
        public double WindPercent { get; set; }
        public double OtherPercent { get; set; }
        public LithiumIonBattery GridCapacity { get; set; }
        public DayReport(string date)
        {
            tupleList = new List<Tuple<string, List<int>>>();
            Date = date;
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
            string prompt = $"Summary for {Date}: ";
            foreach (Tuple<string, List<int>> tup in TupleList)
            {
                prompt += $", {tup.Item1}: {tup.Item2.Sum()} watts";
            }
            prompt += $", Solar Generation: {Math.Round(SolarPercent, 4) * 100}%";
            prompt += $", Wind Generation: {Math.Round(WindPercent, 4) * 100}%";


            return prompt;
        }
        public double getWindPercent()
        {
            return Math.Round(WindPercent * 100, 2);
        }
        public double getSolarPercent()
        {
            return Math.Round(SolarPercent * 100, 2);
        }
        public double getCleanEnergy()
        {
            return this.RetrieveItem("Overall Generation").Item2.Sum();
        }
        public double getEmissionEnergy()
        {
            List<int> gridNeedsAll = this.RetrieveItem("Overall Grid Needs").Item2;
            double totalUsage = 0;
            foreach (int i in gridNeedsAll)
            {
                if(i > 0)
                {
                    totalUsage += i;
                }
            }
            return totalUsage;
        }
        public int getConsumption()
        {
            return this.RetrieveItem("Overall Consumption").Item2.Sum();
        }
        public double getEmissions()
        {
            double cleanEnergyProportion = (double)getCleanEnergy() / (double)(getCleanEnergy() + getEmissionEnergy());
            double overallEmissionFactor = (cleanEnergyProportion * cleanEmissionFactor) + ((1 - cleanEnergyProportion) * emissionEmissonFactor);
            return Math.Round(getConsumption() * overallEmissionFactor, 2);
        }
        public double getNet() {
            return getConsumption() - getCleanEnergy();
        }
        public decimal getGridCost() {
            return Math.Round((decimal)((getEmissionEnergy()/1000) * 0.212),2);
        }
        public decimal getDaySavings() {
            return getNegatedGridCost() + getGridBuyBack();
        }
        public decimal getGridBuyBack()
        {
            //Sum all negative values in gridNeeds
            List<int> gridNeeds = this.RetrieveItem("Overall Grid Needs").Item2;
            decimal buyBack = 0;
            foreach (int value in gridNeeds)
            {
                if(value < 0)
                {
                    buyBack += Math.Abs(value);
                }
            }
            return Math.Round((buyBack/1000) * (decimal)0.212, 2);
        }

        internal decimal getEffectiveCost()
        {
            return Math.Round((decimal)((getConsumption() / 1000) * 0.212), 2);
        }

        public decimal getNegatedGridCost() {
            return getEffectiveCost() - getGridCost();
        }
    }
}
