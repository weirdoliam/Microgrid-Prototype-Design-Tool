using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    abstract class EnergyIn
    {

        //in something..
        protected int dailyEmissions;
        //watts
        //protected int dailyGeneration;

        //watts capacity
        protected int watts;

        public decimal Price { get; set; }

        public int Watts { get => watts; }

        protected bool isArray;

        public bool IsArray { get => isArray; }

        public abstract int getDailyEmissions();

        public abstract int getHalfHourlyGeneration(string currTime, int iterationNo);

        public abstract int getDailyGeneration();

        public abstract string getArrayDescription();

        public abstract string getProductDecription();
    }
}
