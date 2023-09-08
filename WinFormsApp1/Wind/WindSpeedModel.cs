using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Wind
{
    internal class WindSpeedModel
    {
        Dictionary<string, List<double>> windCache = new Dictionary<string, List<double>>();
        Random r = new Random();


        public List<double> getDailySpeeds(string date)
        {
            int max = r.Next(9, 15);
            int min = r.Next(1, 10);
            return getDailySpeeds(date, max, min);
        }

        public int getLength()
        {
            //returns the length of the cache
            return windCache.Count;
        }

        //Speeds are in m/s
        public List<double> getDailySpeeds(string date, int maxSpeed, int minSpeed)
        {
            //Console.WriteLine("Date is: " + date);
            //see if we can strip out the time from the date - not needed in this particular algorithm
            if (windCache.ContainsKey(date))
            {
                return windCache[date];
            }
            else
            {
                //Generate an empty list fot the date.
                List<double> newSpeeds = new List<double>();
                //first pass, generate 48 points as a sin curve between the max and min speed
                //  48 for half hours
                //  24 for hours
                //  12 for 2-hourly and so on
                double p = 48;

                //use weibull distribution
                Weibull w = new Weibull(2, (maxSpeed + minSpeed) / 2);
                for (int i = 0; i < p; i++)
                {
                    newSpeeds.Add(w.Sample());
                }
                windCache.Add(date, newSpeeds);
                return newSpeeds;
            }
        }

        public void replaceSpeedsAtDate(string date, List<double> speeds)
        {
            if (windCache.ContainsKey(date))
            {
                windCache[date] = speeds;
            }
            else windCache.Add(date, speeds);
        }

        
    }
}
