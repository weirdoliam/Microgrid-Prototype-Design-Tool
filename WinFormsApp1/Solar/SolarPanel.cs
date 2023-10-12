using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Solar
{
    class SolarPanel : EnergyIn
    {
        //A string to define notable types if applicable. Generally Commercial vs Residential
        protected string type;
        //in metres
        protected float width;
        protected float length;
        // Cell information 
        protected int cells;
        protected string material;
        //General efficiency (typically the same across most panels)
        protected int hours_till_efficient;
        /// <summary>
        /// Create a new SolarPanel Object
        /// </summary>
        /// <param name="_type">Commercial vs Residential</param>
        /// <param name="_width">Width of panel in metres</param>
        /// <param name="_length">Length of panel in metres</param>
        /// <param name="_watts">Wattage of panel</param>
        /// <param name="_cells">How many solar cells in the panel</param>
        /// <param name="_material">What material the material is made out of</param>
        /// <param name="_price">Manually set the price of obj</param>
        public SolarPanel(string _type, float _width, float _length, int _watts, int _cells, string _material, decimal _price, int _hours)
        {
            type = _type;
            width = _width;
            length = _length;
            watts = _watts;
            cells = _cells;
            material = _material;
            dailyEmissions = 0;
            isArray = false;
            Price = _price;
            hours_till_efficient = _hours;
        }

        Random r = new Random();

        public override string getArrayDescription()
        {
            return "Error: Product not array";
        }
        public override string getProductDecription()
        {
            return type + " panel, " + length + "m x " + width + "m, " + cells + " cells, " + watts + "W, " + material;
        }

        public override int getDailyEmissions()
        {
            return dailyEmissions;
        }

        //Return the general daily generation in kWh
        public override int getDailyGeneration()
        {
            float hours = Cache.currDay.getDaylightHours() + Cache.currDay.getDaylightMinutes() / 60;
            float kwh = (int)(watts * hours / 1000);
            return (int)kwh;
        }
            
        public override int getHalfHourlyGeneration(string currTime, int iterationNo)
        {
            //base gen is wattage / 2 as this is half an hour of power generation. 
            float baseGen = watts / 2;
            //A 1/100 of baseGen is acquired to emulate random dips in performance
            float hundredthOfBase = watts / 100;
            //Create dateTime to represent currTime
            DateTime currentDateTime = DateTime.Parse(currTime);
            int t = hours_till_efficient * 3600;
            //time to start counting down to sunset instead of up after sunrise
            DateTime midday1 = new DateTime(Cache.currDay.Year, Cache.currDay.Month, Cache.currDay.Day, Cache.currDay.getSunrise().Hour + hours_till_efficient, 0, 0);
            DateTime midday2 = new DateTime(Cache.currDay.Year, Cache.currDay.Month, Cache.currDay.Day, Cache.currDay.getSunset().Hour - hours_till_efficient, 0, 0);
            
            //If the sun is up
            if (Cache.currDay.getSunrise() < currentDateTime & currentDateTime < Cache.currDay.getSunset())
            {
                //we won't be at peak power until its X hours after sunrise
                //timespans for measuring where we are in the day in relation to sunrise and set
                TimeSpan afterRise = currentDateTime - Cache.currDay.getSunrise();
                TimeSpan beforeSet = Cache.currDay.getSunset() - currentDateTime;

                //Sin wave definition (for smooth ramping up and down, shape like a sin wave)
                float max = (int)baseGen;
                float min = 0;
                float a = (max - min) / 2;
                float b = (float)(Math.PI) / t;
                float c = 0.5f * t;
                float d = max - a;

                //now depending on what the time is we decide which value to go with
                //c += 0.5f * p;
                int rampedValue1 = (int)(a * Math.Sin(b * (afterRise.TotalSeconds - c)) + d);
                int rampedValue2 = (int)(a * Math.Sin(b * (beforeSet.TotalSeconds - c)) + d);

                baseGen = (currentDateTime < midday1 & currentDateTime > midday2) ? Math.Min(rampedValue1, rampedValue2) : 
                    (currentDateTime < midday1) ? rampedValue1 : 
                    (currentDateTime > midday2) ? rampedValue2 : 
                    baseGen;
            }
            else
            {
                //suns down
                baseGen = 0;
            }
            //Random performance drop of 0-15% 
            float drop = r.Next(0, 15) * hundredthOfBase;
            return Math.Max((int)baseGen - (int)drop, 0);
        }
    }
}
