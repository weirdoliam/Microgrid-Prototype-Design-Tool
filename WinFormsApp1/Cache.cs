using System;
using System.Collections.Generic;

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

        //Complex Houses (availalbe)
        public static List<HouseModel> houseModels = new List<HouseModel>();

        //The main factory of the application
        public static FactoryModel mainFactory = new FactoryModel("Default Factory");

        //weather
        //Looks like there's nothing here... yet

        //Time stuff
        public static List<DayRiseTimes> yearSunTimes = new List<DayRiseTimes>();

        //default is now with no sunrise or sunset, but is overwritten promptly by form1 (Main form)
        public static DayRiseTimes currDay = new DayRiseTimes(DateTime.Now, DateTime.Now, TimeSpan.Zero);

        //Windspeed model class
        public static WindSpeedModel windModel = new WindSpeedModel();

    }
}


