using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class SimpleHome : EnergyOut
    {
        //kWh
        int dailyConsumption;
        bool energyEfficient;
        int size;

        public SimpleHome(int dailyConsumption, bool energyEfficient, int size)
        {
            this.dailyConsumption = dailyConsumption;
            this.energyEfficient = energyEfficient;
            this.size = size;
        }

        public override string getArrayDescription()
        {
            throw new NotImplementedException();
        }

        public override int getDailyConsumption()
        {
            if (energyEfficient)
            {
                return (dailyConsumption * size) / 2;
            }
            else
            {
                return dailyConsumption * size;
            }
        }

        public override int getDailyEmissions()
        {
            throw new NotImplementedException();
        }

        public override string getProductDecription()
        {
            return "House size: " + size + ", Daily Consumption: " + dailyConsumption + " kWh, Energy Efficient: " + energyEfficient;
        }
    }
}
