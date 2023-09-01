using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsApp1
{
    //Models a house and its consumption over the space of 1 year
    internal class HouseModel : EnergyOut
    {
        //Stores and has calculations for a model of a home that consumes power and stuff
        private bool heatpump;
        //ck is cooking
        private bool ckElectric;
        private bool ckMains;
        private bool ckBottledGas;
        //wh is water heating
        private bool whMains;
        private bool whElectric;
        private bool whWood;
        //sh is space heating
        private bool shElectric;
        private bool shMains;
        private bool shWood;
        private bool shFossilFuels;

        private int adults;
        private int children;
        //In thousands
        private string income;
        //city vs rural
        private string location;

        //is it a special house
        private bool totalsHouse;
        //special values for special house
        private double averageElectric;
        private double averageMains;
        private double averageOther;

        //Dictionary to store days, and watt consumption against time (in 48 half hours)
        public Dictionary<string, List<int>> consumptionData;
        int[] dailyAverage;
        bool averaged;

        /// <summary>
        /// Create a new houseModel
        /// </summary>
        /// <param name="heatpump">Does the house have heatpump</param>
        /// <param name="ckElectric">Electric cooking</param>
        /// <param name="ckMains">Mains gas cooking</param>
        /// <param name="ckBottledGas">bottled gas cooking</param>
        /// <param name="whMains">mains water heating</param>
        /// <param name="whElectric">electric water heating</param>
        /// <param name="whWood">wood water heating</param>
        /// <param name="shElectric">electric space heating</param>
        /// <param name="shMains">mains space heating</param>
        /// <param name="shWood">wood space heating</param>
        /// <param name="shFossilFuels">fossil fuel space heating</param>
        /// <param name="adults">how many adults in house</param>
        /// <param name="children">how many children in house</param>
        /// <param name="income">average income of house</param>
        /// <param name="location">is it rural or city</param>
        public HouseModel(bool heatpump, 
            bool ckElectric, bool ckMains, bool ckBottledGas, 
            bool whElectric, bool whMains, bool whWood, 
            bool shElectric, bool shMains, bool shWood, bool shFossilFuels, 
            int adults, int children, string income, string location)
        {
            this.heatpump = heatpump;
            this.ckElectric = ckElectric;
            this.ckMains = ckMains;
            this.ckBottledGas = ckBottledGas;
            this.whMains = whMains;
            this.whElectric = whElectric;
            this.whWood = whWood;
            this.shElectric = shElectric;
            this.shMains = shMains;
            this.shWood = shWood;
            this.shFossilFuels = shFossilFuels;
            this.adults = adults;
            this.children = children;
            this.income = income;
            this.location = location;
            consumptionData = new Dictionary<string, List<int>>();
            dailyAverage = new int[96];
            averaged = false;
            totalsHouse = false;
        }

        public bool Heatpump { get => heatpump; set => heatpump = value; }
        public bool CkElectric { get => ckElectric; set => ckElectric = value; }
        public bool CkMains { get => ckMains; set => ckMains = value; }
        public bool CkBottledGas { get => ckBottledGas; set => ckBottledGas = value; }
        public bool WhMains { get => whMains; set => whMains = value; }
        public bool WhElectric { get => whElectric; set => whElectric = value; }
        public bool WhWood { get => whWood; set => whWood = value; }
        public bool ShElectric { get => shElectric; set => shElectric = value; }
        public bool ShMains { get => shMains; set => shMains = value; }
        public bool ShWood { get => shWood; set => shWood = value; }
        public bool ShFossilFuels { get => shFossilFuels; set => shFossilFuels = value; }
        public int Adults { get => adults; set => adults = value; }
        public int Children { get => children; set => children = value; }
        public string Income { get => income; set => income = value; }
        public string Location { get => location; set => location = value; }
        public bool TotalsHouse { get => totalsHouse; set => totalsHouse = value; }
        public double AverageElectric { get => averageElectric; set => averageElectric = value; }
        public double AverageMains { get => averageMains; set => averageMains = value; }
        public double AverageOther { get => averageOther; set => averageOther = value; }


        public void addTimeSample(string key, int value)
        {
            if (!consumptionData.ContainsKey(key))
            {
                List<int> array = new List<int>
                {
                    value
                };
                consumptionData.Add(key, array);
                dailyAverage[array.Count-1] += value;
            }
            else
            {
                List<int> array = consumptionData[key];
                array.Add(value);
                consumptionData[key] =  array;
                dailyAverage[array.Count-1] += value;
            }
        }

        public int CalculateSimilarityScore(HouseModel otherHouse)
        {
            if (otherHouse.Equals(this)) return 100;

            int similarityScore = 100;

            if (this.heatpump != otherHouse.heatpump)
                similarityScore -= 5;

            if (this.ckElectric != otherHouse.ckElectric)
                similarityScore -= 5;

            if (this.ckMains != otherHouse.ckMains)
                similarityScore -= 5;

            if (this.ckBottledGas != otherHouse.ckBottledGas)
                similarityScore -= 5;

            if (this.whMains != otherHouse.whMains)
                similarityScore -= 5;

            if (this.whElectric != otherHouse.whElectric)
                similarityScore -= 5;

            if (this.whWood != otherHouse.whWood)
                similarityScore -= 5;

            if (this.shElectric != otherHouse.shElectric)
                similarityScore -= 5;

            if (this.shMains != otherHouse.shMains)
                similarityScore -= 5;

            if (this.shWood != otherHouse.shWood)
                similarityScore -= 5;

            if (this.shFossilFuels != otherHouse.shFossilFuels)
                similarityScore -= 5;

            similarityScore -= Math.Abs(this.adults - otherHouse.adults);
            similarityScore -= Math.Abs(this.children - otherHouse.children);

            if (this.income != otherHouse.income)
                similarityScore -= 5;

            if (this.location != otherHouse.location)
                similarityScore -= 5;

            return similarityScore;
        }

        public override bool Equals(object obj)
        {
            if(obj is HouseModel)
            {
                HouseModel houseModel = (HouseModel)obj;
                if (houseModel.Heatpump == this.heatpump 
                    && houseModel.CkElectric == this.CkElectric && houseModel.CkMains == this.CkMains && houseModel.CkBottledGas == this.CkBottledGas
                    && houseModel.WhElectric == this.WhElectric && houseModel.WhMains == this.WhMains && houseModel.WhWood == this.WhWood
                    && houseModel.ShElectric == this.ShElectric && houseModel.ShMains == this.ShMains && houseModel.ShWood == this.ShWood && houseModel.ShFossilFuels == this.ShFossilFuels
                    && houseModel.Children == this.Children && houseModel.Adults == this.Adults && houseModel.Income == this.Income && houseModel.Location == this.Location)
                {
                    return true;
                }
            }
            return false;
        }

        public List<int> getDailyData(string date)
        {
            if (consumptionData.ContainsKey(date))
            {
                return consumptionData[date];
            }
            else
            {
                try
                {
                    DateTime d = DateTime.Parse(date);
                    return consumptionData[d.Day + "/" + d.Month + "/" + "2022"];
                }
                catch(Exception e)
                {
                    return null;
                }
            }
        }

        public void putDay(string key, List<int> value)
        {
            if (!consumptionData.ContainsKey(key))
            {
                consumptionData.Add(key, value);
            }
            else
            {
                consumptionData[key] = value;
            }
        }

        public List<int> getAverageDailyData()
        {
            List<int> returnVal = new List<int>();
            for (int i = 0; i < dailyAverage.Length; i++)
            {
                returnVal.Add(dailyAverage[i] / consumptionData.Count);
            }
            return returnVal;
        }

        public override string getArrayDescription()
        {
            return this.ToString();
        }

        public override int getDailyConsumption()
        {
            int total = 0;
            List<int> nums = getAverageDailyData();
            foreach (int i in nums)
            {
                total += i;
            }
            return total/1000;

            /**
            // in kwh
            double dailyAverage = 0;
            foreach(List<int> day in consumptionData.Values)
            {
                //averages 48 counts of watt-hours 
                double currDailyConsumption = Queryable.Average(day.AsQueryable());
                //then get that average but in hours instead of half ours
                dailyAverage += currDailyConsumption*24;
            }
            return (int)(dailyAverage/consumptionData.Count) / 1000;
            **/
        }

        public override int getDailyEmissions()
        {
            return 0;
        }

        public override string getProductDecription()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            string description = "House Model: ";
            if (heatpump) description += "Heatpump, ";
            if (ckElectric) description += "Electric Cooking, ";
            if (ckMains) description += "Mains Gas Cooking, ";
            if (ckBottledGas) description += "Bottled Gas Cooking, ";
            if (whElectric) description += "Electric Water Heating, ";
            if (whMains) description += "Mains Gas Water Heating, ";
            if (whWood) description += "Wood Water Heating, ";
            if (shElectric) description += "Electric Space Heating, ";
            if (shMains) description += "Mains Gas Space Heating, ";
            if (shWood) description += "Wood Space Heating, ";
            if (shFossilFuels) description += "Fossil Fuels Space Heating, ";
            description += adults + " adults, " + children + " children, " + income + " p/a income, " + location + " location.";

            if (totalsHouse)
            {
                description = "Totals House";
            }
            return description;
        }

        public string shortDescription() {
            return adults + " adults, " + children + " children, " + income + " p/a income, " + location + " location.";
        }

        public double getElectricPercent()
        {
            double total = 0;
            double electric = 0;
            if (ckElectric) { total++; electric++;  }
            if (ckMains) { total++; }
            if (ckBottledGas) { total++; } 
            if (whElectric) { total++; electric++; }
            if (whMains) { total++; }
            if (whWood) { total++; }
            if (shElectric) { total++; electric++; }
            if (shMains) { total++; }
            if (shWood) { total++; }
            if (shFossilFuels) { total++; }
            return electric / total;
        }
        public double getMainsPercent()
        {
            double total = 0;
            double mains = 0;
            if (ckElectric) { total++; }
            if (ckMains) { total++; mains++; }
            if (ckBottledGas) { total++; }
            if (whElectric) { total++;  }
            if (whMains) { total++; mains++; }
            if (whWood) { total++; }
            if (shElectric) { total++;  }
            if (shMains) { total++; mains++; }
            if (shWood) { total++; }
            if (shFossilFuels) { total++; }
            return mains / total;
        }
        public double getOtherPercent()
        {
            double total = 0;
            double other = 0;
            if (ckElectric) { total++;  }
            if (ckMains) { total++; }
            if (ckBottledGas) { total++; other++; }
            if (whElectric) { total++; }
            if (whMains) { total++; }
            if (whWood) { total++; other++; }
            if (shElectric) { total++; }
            if (shMains) { total++; }
            if (shWood) { total++; other++; }
            if (shFossilFuels) { total++; other++; }
            return other / total;
        }
    }
}
