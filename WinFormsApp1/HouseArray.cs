using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class HouseArray : EnergyOut
    {
        List<SimpleHome> homes = new List<SimpleHome>();
        Random rand = new Random();
        int arrayConsumption;

        public HouseArray(int numHomes)
        {
            int sum = 0;
            for(int i = 0; i < numHomes; i++)
            {
                int boolean = rand.Next(0,2);

                if (boolean == 0) {
                    SimpleHome h = new SimpleHome(rand.Next(15, 27), true, rand.Next(1, 4));
                    sum += h.getDailyConsumption();
                    homes.Add(h);
                }
                else
                {
                    SimpleHome h = new SimpleHome(rand.Next(15, 27), false, rand.Next(1, 4));
                    sum += h.getDailyConsumption();
                    homes.Add(h);
                }
            }
            arrayConsumption = sum;
        }

        internal List<SimpleHome> Homes { get => homes;}

        public override string getArrayDescription()
        {
            return "House Array: " + homes.Count + " random simple Homes. ";
        }

        public override int getDailyConsumption()
        {
            return arrayConsumption;
        }

        public override int getDailyEmissions()
        {
            throw new NotImplementedException();
        }

        public override string getProductDecription()
        {
            return getArrayDescription();
        }
    }
}
