using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Wind
{

    internal class WindTurbine : EnergyIn
    {
        //m
        protected int rotorDiameter;
        //degrees
        protected int rotation;
        //name
        protected string name;
        //kmh
        protected const int CUTOFF = 100;
        protected const int RATED = 55;
        protected const int CUTIN = 13;
        //general effectiveness
        protected double effectiveness;


        public WindTurbine(int watts, int rotorDiameter, int rotation, string name)
        {
            this.watts = watts;
            this.rotorDiameter = rotorDiameter;
            isArray = false;
            this.rotation = rotation;
            this.name = name;
            effectiveness = 0.2;

        }
        public WindTurbine(int watts, int rotorDiameter, int rotation, string name, double effectiveness)
        {
            this.watts = watts;
            this.rotorDiameter = rotorDiameter;
            isArray = false;
            this.rotation = rotation;
            this.name = name;
            this.effectiveness = effectiveness;
        }

        public override string getArrayDescription()
        {
            return "Error. Not an array";
        }

        public override int getDailyEmissions()
        {
            throw new NotImplementedException();
        }

        public override int getDailyGeneration()
        {
            Weibull w = new Weibull(2, 8);
            //in km/h
            int windSpeed = (int)(w.Sample() * 3.6);

            //m/s
            double speed = windSpeed / 3.6;

            //calculate area
            double rotorRadius = rotorDiameter / 2;
            double area = Math.PI * (rotorRadius * rotorRadius);

            //best case cut in halfhourly, then the betz limit peak perf in kWh
            double peakPerformance = watts * 0.593 * 24 / 1000;

            if (windSpeed < CUTIN)
            {
                return 0;
            }
            else if (windSpeed >= CUTIN & windSpeed < RATED)
            {
                //Power(W) = 1 / 2 x ρ x A x v3 
                double currPerformance = 0.5 * 1.225 * area * (speed * speed * speed);
                //curr perf in kWh
                currPerformance = currPerformance * 24 / 1000;
                //return in kWh for the DAY
                if (currPerformance > peakPerformance) return (int)peakPerformance;
                return (int)currPerformance;

            }
            else if (windSpeed >= RATED & windSpeed < CUTOFF)
            {
                return (int)peakPerformance;
            }
            else if (windSpeed >= CUTOFF)
            {
                return 0;
            }
            else return 0;

        }

        public override string getProductDecription()
        {
            return "type: Turbine, " + name + ", " + watts / 1000 + "kW, " + rotorDiameter + "m diameter, Facing " + rotation + " degrees.";
        }

        public override int getHalfHourlyGeneration(string currTime, int iterationNo)
        {
            //we need a list of windspeeds in m/s - WE HAVE KM/H SPEEDS IN HERE ALSO
            //We JUST want the date and NOT time
            string justDate = currTime.Split(' ')[0];
            List<double> windSpeeds = Cache.windModel.getDailySpeeds(justDate);

            //get the current windspeed
            double windspeed = windSpeeds[iterationNo];
            //change m/s into km/h
            double kmhWindSpeed = windspeed * 3.6;

            //calculate area
            double rotorRadius = rotorDiameter / 2;
            double area = Math.PI * (rotorRadius * rotorRadius);

            //best case cut in halfhourly, then the betz limit
            double peakPerformance = watts * 0.5 * 0.593;

            if (kmhWindSpeed < CUTIN)
            {
                return 0;
            }
            else if (kmhWindSpeed >= CUTIN & kmhWindSpeed < RATED)
            {
                //Power(W) = 1 / 2 x ρ x A x v (not cubed3)
                //calculate available power estimate
                //using constant for wind density so far
                double currPerformance = 0.5 * 1.225 * area * windspeed;
                //get the half-hourly value
                currPerformance = currPerformance / 2;
                if (currPerformance > peakPerformance) return (int)peakPerformance;
                return (int)currPerformance;
            }
            else if (kmhWindSpeed >= RATED & kmhWindSpeed < CUTOFF)
            {
                return (int)peakPerformance;
            }
            else if (windspeed >= CUTOFF)
            {
                return 0;
            }
            else return 0;
        }
    }
}
