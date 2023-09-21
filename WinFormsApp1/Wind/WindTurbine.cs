using MathNet.Numerics.Distributions;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Wind
{

    internal class WindTurbine : EnergyIn
    {
        //m
        protected int rotorDiameter;
        //degrees from north (90 being east, 180 being south, etc)
        protected int rotation;
        //name
        protected string name;
        //kmh
        protected int cutoff;
        protected int rated;
        protected int cutin;
        //general effectiveness
        protected double effectiveness;


        public WindTurbine(int watts, int rotorDiameter, int rotation, string name, int cutin, int rated, int cutoff)
        {
            this.watts = watts;
            this.rotorDiameter = rotorDiameter;
            isArray = false;
            this.rotation = rotation;
            this.name = name;
            effectiveness = 0.2;
            this.cutoff = cutoff;
            this.rated = rated;
            this.cutin = cutin;
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

            if (windSpeed < cutin)
            {
                return 0;
            }
            else if (windSpeed >= cutin & windSpeed < rated)
            {
                //Power(W) = 1 / 2 x ρ x A x v3 
                double currPerformance = 0.5 * 1.225 * area * (speed * speed * speed);
                //curr perf in kWh
                currPerformance = currPerformance * 24 / 1000;
                //return in kWh for the DAY
                if (currPerformance > peakPerformance) return (int)peakPerformance;
                return (int)currPerformance;

            }
            else if (windSpeed >= rated & windSpeed < cutoff)
            {
                return (int)peakPerformance;
            }
            else if (windSpeed >= cutoff)
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
            //we need a list of windspeeds in m/s -
            //We have KM/H SPEEDS in here also, labelled
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

            //best case cut in halfhourly
            double peakPerformance = watts * 0.5;

            if (kmhWindSpeed < cutin)
            {
                return 0;
            }
            else if (kmhWindSpeed >= cutin & kmhWindSpeed < rated)
            {
                //Apply the betz limit to windspeed
                windspeed = windspeed * 0.593;

                //Power(W) = 1 / 2 x ρ x A x v (not cubed3)
                //calculate available power estimate
                //using constant for wind density so far
                double currPerformance = 0.5 * 1.225 * area * (windspeed*windspeed*windspeed);
                //get the half-hourly value
                currPerformance = currPerformance / 2;
                return (int)Math.Min(peakPerformance,currPerformance);
            }
            else if (kmhWindSpeed >= rated & kmhWindSpeed < cutoff)
            {
                return (int)peakPerformance;
            }
            else if (windspeed >= cutoff)
            {
                return 0;
            }
            else return 0;
        }
    }
}
