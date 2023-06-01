using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal static class DailyReporter
    {


        // Calculates entire content, from scratch Will break it down once it's created
        
        public static List<int> GenerateReport(DateTime date)
        {
            //From all generators, calculate the generation load
            List<int> overallGen = new List<int>();

            string parsedDate = date.Day + "/" + date.Month + "/" + date.Year;
            string currTime = "00:00";
            int hour = 0;
            int minute = 0;
            
            for (int i = 0; i < 48; i++)
            {
                int currTotal = 0;
                foreach (EnergyIn generator in Cache.genListin)
                {
                    currTotal += generator.getHalfHourlyGeneration($"{parsedDate} {currTime}", i);
                }

                overallGen.Add(currTotal);
                
                minute += 30;

                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                }
                currTime = hour + ":" + minute;
                if (minute == 0) currTime = currTime + "0";
                if (hour < 10) currTime = "0" + currTime;
            }


            //from all consumers, calculate the consumption load
            //factory load added separately.
            List<double> factoryLoad = Cache.mainFactory.GetHourlyConsumptionList();

            //for all batteries and storage, calculate the state of power storage through the day, based on current supply vs current demand


            //For times of demand when storage is empty, take power from grid instead (therefore adding more carbon emissions, or cost)


            //return report 
            return overallGen;
        }
    }
}
