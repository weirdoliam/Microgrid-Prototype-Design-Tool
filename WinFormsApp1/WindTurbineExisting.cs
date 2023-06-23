using System;
using System.Collections.Generic;

namespace WinFormsApp1
{
    internal class WindTurbineExisting : EnergyIn
    {
        //general details
        private string name;
        private string manufacturer;
        //in kW
        private int ratedPower;
        //in m
        private double rotorDiameter;
        //in m^2
        private double sweptArea;
        private int numBlades;

        //in m/s
        private double cutInSpeed;
        private double ratedSpeed;
        private double cutOutSpeed;

        //power curve
        private Dictionary<double, int> curve = null;

        //amount if we're storing an "array" of these objects
        private int amount;

        public Dictionary<double, int> Curve { get => curve; set => curve = value; }
        public string Name { get => name; set => name = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        protected int RatedPower { get => ratedPower; set => ratedPower = value; }
        protected double RotorDiameter { get => rotorDiameter; set => rotorDiameter = value; }
        protected double SweptArea { get => sweptArea; set => sweptArea = value; }
        protected int NumBlades { get => numBlades; set => numBlades = value; }
        protected double CutInSpeed { get => cutInSpeed; set => cutInSpeed = value; }
        protected double RatedSpeed { get => ratedSpeed; set => ratedSpeed = value; }
        protected double CutOutSpeed { get => cutOutSpeed; set => cutOutSpeed = value; }
        public int Amount { get => amount; set => amount = value; }


        /// <summary>
        /// Create a new existirng wind turbine
        /// </summary>
        /// <param name="name">Model Number</param>
        /// <param name="manufacturer">Manufacturer of turbine</param>
        /// <param name="ratedPower">Rated power in kW</param>
        /// <param name="rotorDiameter">diameter in m</param>
        /// <param name="sweptArea">in m^2</param>
        /// <param name="numBlades">amount of blades on turbine</param>
        /// <param name="cutInSpeed">in m/s</param>
        /// <param name="ratedSpeed">in m/s</param>
        /// <param name="cutOutSpeed">in m/s</param>
        public WindTurbineExisting(string name, 
            string manufacturer, 
            int ratedPower, 
            double rotorDiameter, 
            double sweptArea, 
            int numBlades, 
            double cutInSpeed, 
            double ratedSpeed, 
            double cutOutSpeed)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.ratedPower = ratedPower;
            this.rotorDiameter = rotorDiameter;
            this.sweptArea = sweptArea;
            this.numBlades = numBlades;
            this.cutInSpeed = cutInSpeed;
            this.ratedSpeed = ratedSpeed;
            this.cutOutSpeed = cutOutSpeed;
            watts = ratedPower;
            amount = 1;
            isArray = false;
            CalculatePrice();
        }
        public WindTurbineExisting(string name,
            string manufacturer,
            int ratedPower,
            double rotorDiameter,
            double sweptArea,
            int numBlades,
            double cutInSpeed,
            double ratedSpeed,
            double cutOutSpeed, 
            int amount)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.ratedPower = ratedPower;
            this.rotorDiameter = rotorDiameter;
            this.sweptArea = sweptArea;
            this.numBlades = numBlades;
            this.cutInSpeed = cutInSpeed;
            this.ratedSpeed = ratedSpeed;
            this.cutOutSpeed = cutOutSpeed;
            watts = ratedPower;

            this.amount = amount;
            isArray = true;
            CalculatePrice();
        }
        private void CalculatePrice()
        {
            Price = (decimal)(amount * watts * 1.15);
        }

        public bool hasPowerCurve()
        {
            if (curve != null) return true;
            else return false;
        }

        public override string getArrayDescription()
        {
            string returnString = "ExistingTurbine";
            if (curve == null)
            {
                returnString += $"{returnString}{manufacturer},{name},{ratedPower/1000}kW";
            }
            else
            {
                returnString += $"{returnString}{manufacturer},{name},{ratedPower/1000}kW,contains power curve data";
            }
            if (isArray)
            {
                returnString += $",{amount}";
            }
            return returnString;
        }

        public override int getDailyEmissions()
        {
            return 0;
        }

        public override int getDailyGeneration()
        {
            if (isArray) return ratedPower * 24 * amount;
            else return ratedPower*24;
        }

        public override int getHalfHourlyGeneration(string currTime, int iterationNo)
        {
            int returnAmount = 0;
            if (curve != null)
            {
                //we need a list of windspeeds in m/s - WE HAVE KM/H SPEEDS IN HERE ALSO
                //We JUST want the date and NOT time
                string justDate = currTime.Split(' ')[0];
                List<double> windSpeeds = Cache.windModel.getDailySpeeds(justDate);
                //get the current windspeed
                double windspeed = windSpeeds[iterationNo];
                returnAmount =  getExistingPerformance(windspeed)/2;

            }
            else 
            {
                WindTurbine w = new WindTurbine(ratedPower, (int)rotorDiameter, 0, name);
                returnAmount = w.getHalfHourlyGeneration(currTime, iterationNo);
            }

            if (isArray) return returnAmount * amount;
            else return returnAmount;
        }

        /// <summary>
        /// Returns the performance of the turbine at the current windspeed
        /// </summary>
        /// <param name="key">windspeed in m/s</param>
        /// <returns></returns>
        public int getExistingPerformance(double windspeed)
        {
            if(windspeed > 35)
            {
                return 0;
            }
            //only if we have a power curve do we return something
           

            //get nearest .5 below and above

            double lower = rounder(windspeed);
            double upper = rounder(windspeed + 0.5);

            if (lower > windspeed)
            {
                upper = lower;
                lower = rounder(windspeed - 0.5);
            }
            if (upper > 35)
            {
                upper = 35;
            }
            int upperWattage = curve[upper];
            int lowerWattage = curve[lower];
            int val = (int)((upperWattage + lowerWattage) / 2);
            if (isArray) return val * amount;
            return val;
            //*/
            //return curve[rounder(windspeed)];
          
        }

        //rounding function to help
        private double rounder(double x)
        {
            double baseNum = 0.5;
            return baseNum * Math.Round(x / baseNum);
        }

        public override string getProductDecription()
        {
            return getArrayDescription();
        }
    }
}
