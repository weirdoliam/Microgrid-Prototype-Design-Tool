using System;
using System.Collections.Generic;
using System.Linq;
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

            //Overall Gen done. It wokrs. No complaints


            //from all consumers, calculate the consumption load
            List<int> overallConsumption = new List<int>();


            //factory load added separately.
            List<double> factoryLoad = Cache.mainFactory.GetHourlyConsumptionList(date);
            if (factoryLoad == null) factoryLoad = Cache.mainFactory.GetHourlyConsumptionList();

            List<int> factoryInts = new List<int>();
            foreach (double d in factoryLoad) factoryInts.Add((int)d);

            List<List<int>> lists = new List<List<int>>();
            foreach (EnergyOut consumer in Cache.genListOut)
            {
                if (consumer is HouseModel)
                {
                    HouseModel house = (HouseModel)consumer;
                    lists.Add(house.getDailyData(parsedDate));
                }
            }
            List<int> resultList = lists.Aggregate((acc, curr) => acc.Zip(curr, (a, b) => a + b).ToList());
            overallConsumption = resultList.Zip(factoryInts, (a, b) => a + b).ToList();
            //for all batteries and storage, calculate the state of power storage through the day, based on current supply vs current demand


            //For times of demand when storage is empty, take power from grid instead (therefore adding more carbon emissions, or cost)


            //return report 
            return overallConsumption;
        }
    }
}
