using MathNet.Numerics;
using System;
using System.Collections.Generic;
using WinFormsApp1.EnergyStorage;

namespace WinFormsApp1
{
    internal static class Cache
    {
        //storing all data for the microgrid
        //Lists for storing Avaialble Generators
        public static List<WindTurbineExisting> availableTurbines = new List<WindTurbineExisting>();

        //list of power curves... Just incase
        public static List<WindTurbinePowerCurve> curves = new List<WindTurbinePowerCurve>();

        //energy generation objects
        public static List<EnergyIn> genListin = new List<EnergyIn>();

        //Energy consumer objects
        public static List<EnergyOut> genListOut = new List<EnergyOut>();

        //Energy Storage objects
        public static List<EnergyStorageUnit> energyStorageUnits = new List<EnergyStorageUnit>();

        //Complex Houses (availalbe)
        public static List<HouseModel> houseModels = new List<HouseModel>();

        //The main factory of the application
        public static FactoryModel mainFactory = new FactoryModel("Default Factory");

        //Windspeed model class
        public static WindSpeedModel windModel = new WindSpeedModel();

        //Time stuff
        public static List<DayRiseTimes> yearSunTimes = new List<DayRiseTimes>();

        //default is now with no sunrise or sunset, but is overwritten promptly by form1 (Main form)
        public static DayRiseTimes currDay = new DayRiseTimes(DateTime.Now, DateTime.Now, TimeSpan.Zero);
        //Calculates the cost of each battery and generator
        public static decimal getSetupCost() {
            decimal sum = 0;
            foreach (EnergyIn e in genListin)
            {
                sum += e.Price;
            }
            foreach (EnergyStorageUnit e in energyStorageUnits)
            {
                sum += e.Price;
            }
            return sum;
        }
    }
}


