using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Solar
{
    internal class SolarPanelArray : SolarPanel
    {
        int amount;

        public int Amount { get => amount; }

        public SolarPanelArray(string _type, float _width, float _length, int _watts, int _cells, string _material, int amount, decimal _price, int _hours)
            : base(_type, _width, _length, _watts, _cells, _material, _price, _hours)
        {
            this.amount = amount;
            isArray = true;
            Price = amount * _price;
        }

        public override int getHalfHourlyGeneration(string currTime, int iterationNo)
        {
            int total = 0;
            for (int i = 0; i < amount; i++) total += base.getHalfHourlyGeneration(currTime, iterationNo);
            return total;
        }

        public override int getDailyEmissions()
        {
            return base.getDailyEmissions() * amount;
        }

        public override int getDailyGeneration()
        {
            return base.getDailyGeneration() * amount;
        }

        public override string getArrayDescription()
        {
            return type + " Solar Array, " + amount + " units";
        }

        

        /// <summary>
        /// Overload for removing product of array
        /// </summary>
        /// <param name="currTime"></param>
        /// <param name="iterationNo"></param>
        /// <param name="accumulate">If you want to exclude the totaling of all arrays enter FALSE</param>
        /// <returns></returns>
        public int getHalfHourlyGeneration(string currTime, int iterationNo, bool accumulate)
        {
            if (!accumulate) return base.getHalfHourlyGeneration(currTime, iterationNo);
            else return getHalfHourlyGeneration(currTime, iterationNo);
        }

        public SolarPanel getPanelObject()
        {
            return new SolarPanel(type, width, length, watts, cells, material, Price, hours_till_efficient);
        }
    }
}