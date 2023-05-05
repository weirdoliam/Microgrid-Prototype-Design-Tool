using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal abstract class EnergyOut
    {
        //in something..
        protected int dailyEmissions;
        //watts
        //protected int dailyGeneration;

        //watts capacity
        protected int watts;

        protected int consumptionWatts;

        public int Watts { get => watts; }

        public int Consuming { get => consumptionWatts; set => consumptionWatts = value; }

        public abstract int getDailyEmissions();

        public abstract int getDailyConsumption();

        public abstract string getArrayDescription();

        public abstract string getProductDecription();
    }
}
