using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using WinFormsApp1.EnergyStorage;

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

            //THere's a couple ways I wanna do this. One is to create an instance of a large battery which has the sums of all other batteries combined, and this will be used for the report.
            double totalCapacity = 0;
            double totalChargeRate = 0;
            foreach (EnergyStorageUnit esu in Cache.energyStorageUnits)
            {
                if (esu is LithiumIonBattery)
                {
                    LithiumIonBattery lib = (LithiumIonBattery)esu;
                    totalCapacity += lib.Capacity;
                    totalChargeRate += lib.MaxChargeRate;
                }
            }
            LithiumIonBattery reportBattry = new LithiumIonBattery(totalCapacity, totalChargeRate, "Report Battery");
            
            //Generate a list of state of charge throughout the day
            List<int> storageCharge = new List<int>();
            //For times of demand when storage is empty, take power from grid instead (therefore adding more carbon emissions, or cost)
            int currDemand, currSupply, net = 0;
            double giveToGrid = 0;
            double needFromGrid = 0;
            double excess = 0;
            double recievedCharge, currCharge = 0;
            decimal todaysCostFromGrid = 0;
            
            for(int i = 0; i < 48; i++)
            {
                currDemand = overallConsumption[i];
                currSupply = overallGen[i];
                net = currDemand - currSupply;
                //Console.WriteLine($"Net: {net}");
                //if net is less than zero we have charge!
                if (net < 0)
                {
                    //Console.WriteLine($"Charging Battery: {-net}");
                    giveToGrid = reportBattry.Charge(-net);
                    //Console.WriteLine($"Energy Unable to be charged in half-hour: {giveToGrid}");
                    needFromGrid = 0;
                }
                //if net is more than zero, we deduct charge
                if (net > 0)
                {
                    //Console.WriteLine($"Discharging:{net}");
                    recievedCharge = reportBattry.Discharge(net);
                    needFromGrid = net - recievedCharge;
                    //Console.WriteLine($"Energy Recieved:{recievedCharge}, need from grid to makeup: {needFromGrid}");
                    giveToGrid = 0;
                }
                currCharge = reportBattry.ChargeLevel;
                //Console.WriteLine($"Current Charge after calculations: {currCharge}");
                excess = excess + (needFromGrid - giveToGrid);
                storageCharge.Add((int)currCharge);
            }
            // Hamilton	21.2c
            todaysCostFromGrid = (decimal)(excess/1000 * 0.212);
            Console.WriteLine($"${todaysCostFromGrid.Round(2)}");
            //return report 
            return storageCharge;
        }
    }
}
