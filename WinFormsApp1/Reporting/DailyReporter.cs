using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.EnergyStorage;
using WinFormsApp1.Solar;
using WinFormsApp1.Wind;

namespace WinFormsApp1.Reporting
{
    internal static class DailyReporter
    {

        // Calculates entire content, from scratch, will break it down once it's created
        public static DayReport GenerateReport(DateTime date, int start_capacity)
        {
            int totalWatts = 0;
            int solarGeneration = 0;
            int otherGeneration = 0;
            int windGeneration = 0;

            //Deliverable
            DayReport dayReport = new DayReport($"{date.Day}.{date.Month}.{date.Year}");
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
                    int gen = generator.getHalfHourlyGeneration($"{parsedDate} {currTime}", i);
                    currTotal += gen;
                    totalWatts += gen;
                    
                    if (generator is SolarPanelArray)
                    {
                        solarGeneration += gen;
                    }
                    if (generator is WindTurbineArray)
                    {
                        windGeneration += gen;
                    }
                    if (generator is WindTurbineExisting)
                    {
                        windGeneration += gen;
                    }
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
            dayReport.InsertItem("Overall Generation", overallGen);

            //do generator totals
            dayReport.WindPercent = (double)windGeneration / (double)totalWatts;
            dayReport.SolarPercent = (double)solarGeneration / (double)totalWatts;
            dayReport.OtherPercent = (double)otherGeneration / (double)totalWatts;
            //Overall Gen done.

            //from all consumers, calculate the consumption load
            List<int> overallConsumption = new List<int>();

            List<double> factoryLoad = null;
            //factory load added separately.
            if (Cache.mainFactory.UsesCompLoad)
            {
                factoryLoad = Cache.mainFactory.GetHourlyConsumptionList(date);

            }
            if (factoryLoad == null) factoryLoad = Cache.mainFactory.GetHourlyConsumptionList();

            List<int> factoryInts = factoryLoad.ConvertAll(d => (int)d);

            List<List<int>> lists = new List<List<int>>();
            foreach (EnergyOut consumer in Cache.genListOut)
            {
                if (consumer is HouseModel)
                {
                    HouseModel house = (HouseModel)consumer;
                    List<int> dailyData = house.getDailyData(parsedDate);
                    if (dailyData != null) { lists.Add(dailyData); }
                }
            }

            if (lists.Count > 0)
            {
                List<int> resultList = lists.Aggregate((acc, curr) => acc.Zip(curr, (a, b) => a + b).ToList());
                overallConsumption = resultList.Zip(factoryInts, (a, b) => a + b).ToList();
            }
            else overallConsumption = factoryInts;

            dayReport.InsertItem("Overall Consumption", overallConsumption);
            //Daily Consumption done.

            //for all batteries and storage, calculate the state of power storage through the day, based on current supply vs current demand

            //create an instance of a large battery which has the sums of all other batteries combined, and this will be used for the report.
            double totalCapacity = 0;
            double totalChargeRate = 0;
            decimal totalCost = 0;
            foreach (EnergyStorageUnit esu in Cache.energyStorageUnits)
            {
                if (esu is LithiumIonBattery)
                {
                    LithiumIonBattery lib = (LithiumIonBattery)esu;
                    totalCapacity += lib.Capacity;
                    totalChargeRate += lib.MaxChargeRate;
                    totalCost += lib.Price;
                }
            }
            //Big ol battry :D
            LithiumIonBattery reportBattry = new LithiumIonBattery(totalCapacity, totalChargeRate, "Report Battery", totalCost);
            if (start_capacity >= 0) reportBattry.overrideCharge(start_capacity);
            //Generate a list of state of charge throughout the day
            List<int> storageCharge = new List<int>();
            //Generate a list of times when the grid requires power from the grid, and when it gives to the grid
            List<int> gridNeeds = new List<int>();
            //For energy balance plot
            List<int> balanceCon = new List<int>();
            List<int> balanceGen = new List<int>();

            int currDemand, currSupply, net = 0;
            double giveToGrid = 0;
            double needFromGrid = 0;
            double recievedCharge, currCharge = 0;

            //For times of demand when storage is empty, take power from grid instead (therefore adding more carbon emissions and cost)
            for (int i = 0; i < 48; i++)
            {
                currDemand = i >= overallConsumption.Count ? 0 : overallConsumption[i];
                currSupply = i >= overallGen.Count ? 0 : overallGen[i];
                
                //For energy balance plot
                int gen_and_taken = currSupply;
                int consume_and_given = currDemand;

                net = currDemand - currSupply;
                //Console.WriteLine($"Net: {net}");
                //if net is less than zero we have charge!
                if (net < 0)
                {
                    //Console.WriteLine($"Charging Battery: {-net}");
                    giveToGrid = reportBattry.Charge(-net);
                    int chargedAmount = Math.Abs(-net - (int)giveToGrid);
                    //Console.WriteLine($"Energy Unable to be charged in half-hour: {giveToGrid}");
                    needFromGrid = 0;
                    consume_and_given += chargedAmount;
                }
                //if net is more than zero, we deduct charge
                if (net > 0)
                {
                    
                    //Console.WriteLine($"Discharging:{net}");
                    recievedCharge = reportBattry.Discharge(net);
                    needFromGrid = net - recievedCharge;
                    //Console.WriteLine($"Energy Recieved:{recievedCharge}, need from grid to makeup: {needFromGrid}");
                    giveToGrid = 0;
                    gen_and_taken += (int)recievedCharge;
                }
                if (net == 0)
                {
                    needFromGrid = 0;
                    giveToGrid = 0;
                }
                balanceCon.Add(consume_and_given);
                balanceGen.Add(gen_and_taken);
                currCharge = reportBattry.ChargeLevel;
                
                //Console.WriteLine($"Current Charge after calculations: {currCharge}");
                gridNeeds.Add((int)(needFromGrid - giveToGrid));
                storageCharge.Add((int)currCharge);
            }
            dayReport.InsertItem("Battery Usage", storageCharge);
            dayReport.InsertItem("Overall Grid Needs", gridNeeds);

            dayReport.InsertItem("Balanced Generation", balanceGen);
            dayReport.InsertItem("Balanced Consumption", balanceCon);

            //battery alignment
            dayReport.GridCapacity = reportBattry;
                        
            return dayReport;
        }
    }
}
