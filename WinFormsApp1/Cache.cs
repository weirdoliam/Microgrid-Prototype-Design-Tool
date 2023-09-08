using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using WinFormsApp1.EnergyStorage;
using WinFormsApp1.utilForms;
using WinFormsApp1.Wind;

namespace WinFormsApp1
{
    internal static class Cache
    {
        //storing all data for the microgrid

        //energy generation objects
        public static List<EnergyIn> genListin = new List<EnergyIn>();

        //Energy consumer objects
        public static List<EnergyOut> genListOut = new List<EnergyOut>();

        //Energy Storage objects
        public static List<EnergyStorageUnit> energyStorageUnits = new List<EnergyStorageUnit>();

        //Default DRT is Curr Time with no sunrise or sunset, but is overwritten promptly by form1 (Main form)
        public static DayRiseTimes currDay = new DayRiseTimes(DateTime.Now, DateTime.Now, TimeSpan.Zero);

        //Daylight Profile (Default is Waikato Region)
        public static List<DayRiseTimes> yearSunTimes = new List<DayRiseTimes>();

        //The main factory of the application
        public static FactoryModel mainFactory = new FactoryModel("Default Factory");

        //Complex Houses (availalbe)
        public static List<HouseModel> houseModels = new List<HouseModel>();

        //Windspeed model class
        public static WindSpeedModel windModel = new WindSpeedModel();

        //Lists for storing Avaialble Generators
        public static List<WindTurbineExisting> availableTurbines = new List<WindTurbineExisting>();

        //list of power curves... Just incase
        public static List<WindTurbinePowerCurve> curves = new List<WindTurbinePowerCurve>();

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


