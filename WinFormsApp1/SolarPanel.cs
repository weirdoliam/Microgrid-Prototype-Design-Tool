using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class SolarPanel : EnergyIn
    {
        protected string type;
        //in metres
        protected float width;
        protected float length;
        //
        protected int cells;
        protected string material;
        Random r = new Random();

        /// <summary>
        /// Create a new SolarPanel Object
        /// </summary>
        /// <param name="_type">Commercial vs Residential</param>
        /// <param name="_width">Width of panel in metres</param>
        /// <param name="_length">Length of panel in metres</param>
        /// <param name="_watts">Wattage of panel</param>
        /// <param name="_cells">How many solar cells in the panel</param>
        /// <param name="_material">What material the material is made out of</param>
        public SolarPanel(string _type, float _width, float _length, int _watts, int _cells, string _material)
        {
            type = _type;
            width = _width;
            length = _length;
            watts = _watts;
            cells = _cells;
            material = _material;
            dailyEmissions = 0;
            isArray = false;    
        }

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

        //in kWh
        public override int getDailyGeneration()
        {
            float hours = Cache.currDay.getDaylightHours() + (Cache.currDay.getDaylightMinutes()/60);
            float kwh = (int)((watts * hours) / 1000);
            //float final = (kwh * w.sun.Effectiveness)/100;
            //MessageBox.Show("kwh: " + kwh + ", final:" + final);
            return (int)kwh;
        }

        public override int getHalfHourlyGeneration(string currTime, int iterationNo)
        {
            //base gen is wattage / 2
            float baseGen = watts / 2;
            DateTime currentDateTime = DateTime.Parse(currTime);

            //hardcoded - generally around 5 hours till we're cooking with GAS for solar panels
            int hoursTillEfficiency = 7;
            int secconds = hoursTillEfficiency * 3600;

            //time to start counting down to sunset instead of up after sunrise
            DateTime midday1 = new DateTime(Cache.currDay.Year, Cache.currDay.Month, Cache.currDay.Day, Cache.currDay.getSunrise().Hour + hoursTillEfficiency, 0, 0);
            DateTime midday2 = new DateTime(Cache.currDay.Year, Cache.currDay.Month, Cache.currDay.Day, Cache.currDay.getSunset().Hour - hoursTillEfficiency, 0, 0);
            //depending on current time, we have lots or not lots
            //
            if (Cache.currDay.getSunrise() < currentDateTime & currentDateTime < Cache.currDay.getSunset())
            {
                //suns up!
                //we won't be at peak power until its 5 hours after sunrise however

                //timespans for measuring where we are in the day in relation to sunrise and set
                TimeSpan afterRise = currentDateTime - Cache.currDay.getSunrise();
                TimeSpan beforeSet = Cache.currDay.getSunset() - currentDateTime;

                //fun maths.... (for smooth ramping up and down, shape like a sin wave)
                float max = (int)baseGen;
                float min = 0;
                float p = 2 * secconds;
                float a = (max - min) / 2;
                float b = (float)(2 * Math.PI) / p;
                float c = 0.25f * p;
                float d = max - a;
                //now depending on what the time is we decide which quotient to go with
                int rampedValue1 = (int)(a * Math.Sin(b * (afterRise.TotalSeconds - c)) + d);
                //c += 0.5f * p;
                int rampedValue2 = (int)(a * Math.Sin(b * (beforeSet.TotalSeconds - c)) + d);

                if (currentDateTime < midday1 & currentDateTime > midday2)
                {
                    baseGen = Math.Min(rampedValue1,rampedValue2);
                }
                else if (currentDateTime < midday1)
                {
                    //now we just get the Y value of Quotient
                    //return that ig?
                    baseGen = rampedValue1;

                }
                else if (currentDateTime > midday2)
                {
                    baseGen = rampedValue2;
                }
               
                else 
                {
                    //max eff baby
                    //no change to baseGen
                }
            }
            else
            {
                //suns down
                baseGen = 0;
            }

            return (int)baseGen;
        }
    }
}
