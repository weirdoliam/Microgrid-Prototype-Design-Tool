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

        public void replaceSpeedsAtDate(string date, List<double> speeds)
        {
            if (windCache.ContainsKey(date))
            {
                windCache[date] = speeds;
            }
            else windCache.Add(date, speeds);
        }

        //Speeds are in m/s
        public List<double> getDailySpeeds(string date, int maxSpeed, int minSpeed)
        {
            //Console.WriteLine("Date is: " + date);
            //see if we can strip out the time from the date (idk why we put it in...)

            //int minSpeed = 12
            if (windCache.ContainsKey(date))
            {
                return windCache[date];
            }
            else
            {

                //Use Sin Wave to generate values
                List<double> newSpeeds = new List<double>();
                //first pass, generate 48 points as a sin curve between the max and min speed

                //P = points for sin wave to cover
                //  48 for half hours
                //  24 for hours
                //  12 for 2-hourly and so on
                double p = 48;

                /*
                //a = amplitude (max-min) / 2
                double a = (maxSpeed - minSpeed) / 2;
                //b = frequency (2pi/P)
                double b = (float)(2 * Math.PI) / p;
                //c = random horizontal offset
                double c = r.Next((int)p);
                //d = vertical shift ( max - amplitutude )
                double d = maxSpeed - a;

                for (int i = 0; i < p; i++)
                {
                    // a sin (B ( x - c ) + d
                    newSpeeds.Add(Math.Round(a * Math.Sin(b * (i - c)) + d, 2));
                    //newSpeeds.Add(i);
                }
                //*/

                //straight line
                /*
                for (int i = 0; i < p; i++)
                {
                    newSpeeds.Add(i);
                }
                //*/


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
    }
}
