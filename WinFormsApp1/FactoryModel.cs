using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    class FactoryModel : EnergyOut
    {

        // Properties
        public string Name { get; set; }
        public List<Tuple<string, double>> Machines { get => machines; }
        public Dictionary<string, List<Tuple<TimeSpan, TimeSpan>>> MachineTimeRanges { get => machineTimeRanges; }
        public bool UsesCompLoad { get => usesCompLoad; }
        public string CompLoadPath { get => compLoadPath; }


        //variable loads per item. 
        //Flexibility in how a load is defined

        // Item Lists. These need to be in sync.
        private List<Tuple<string, double>> machines;
        private Dictionary<string, List<Tuple<TimeSpan, TimeSpan>>> machineTimeRanges = new Dictionary<string, List<Tuple<TimeSpan, TimeSpan>>>();

        //Variable load, and associated bool
        private List<double> genericLoad = new List<double>();
        private bool usesPreLoad = false;

        //Comprehensive load, and associated bool
        //Path to data
        private string compLoadPath = null;
        //date, data (in half-hour intervals)
        private Dictionary<string, double[]> comprehensiveLoad = new Dictionary<string,double[]>();
        private bool usesCompLoad = false;

        // Constructor
        public FactoryModel(string name)
        {
            Name = name;
            machines = new List<Tuple<string, double>>();
            machineTimeRanges = new Dictionary<string, List<Tuple<TimeSpan, TimeSpan>>>();
        }

        public FactoryModel(string name, List<Tuple<string, double>> machines, Dictionary<string, List<Tuple<TimeSpan, TimeSpan>>> machineTimeRanges, List<double> load, bool preLoaded) : this(name)
        {
            this.machines = machines;
            this.machineTimeRanges = machineTimeRanges;
            this.genericLoad = load;
            this.usesPreLoad = preLoaded;
        }

        public FactoryModel Clone() {
            return new FactoryModel(Name, machines, MachineTimeRanges, genericLoad, usesPreLoad);
        }


        public double CalculateDailyPowerConsumption()
        {
            double totalWattage = 0;

            // Calculate total wattage for all items
            foreach (Tuple<string, double> item in machines)
            {
                totalWattage += item.Item2;
            }

            // Convert total wattage to kWh and multiply by 24 hours to get daily power consumption
            double dailyPowerConsumption = (totalWattage / 1000) * 24;
            return dailyPowerConsumption;
        }

        public double CalculateHourlyPowerConsumption()
        {
            double totalWattage = 0;

            // Calculate total wattage for all items
            foreach (Tuple<string, double> item in machines)
            {
                totalWattage += item.Item2;
            }

            // Convert total wattage to kWh
            double hourlyPowerConsumption = totalWattage / 1000;
            return hourlyPowerConsumption;
        }

        public List<double> GetHourlyConsumptionList(DateTime date)
        {
            List<double> data = new List<double>();
            if (!usesCompLoad) return null;
            //we ignore year in date
            string d = date.Day + "";
            string m = date.Month + "";
            //Format appropriately
            if (date.Day < 10)
            {
                d = "0" + d;
            }
            if(date.Month < 10) 
            {
                m = "0" + m;
            }
            string monthDay = $"{m}_{d}";
            if (comprehensiveLoad.ContainsKey(monthDay))
            {
                double[] arrayData = comprehensiveLoad[monthDay];
                foreach (int i in arrayData)
                {
                    Console.WriteLine("Adding data we already have ouptut list: " + i);
                    data.Add(i);
                }
                return data;
            }
            else
            {
                bool success = readInDay(monthDay);
                if (!success) return null; 

                double[] arrayData = comprehensiveLoad[monthDay];
                foreach (int i in arrayData)
                {
                    Console.WriteLine("Adding to ouptut list: " + i);
                    data.Add(i);
                }
                return data;
            }                                                             
        }

        private bool readInDay(string monthDay)
        {
            Console.WriteLine($"Reading in Day: {monthDay}");
            //identify file existence
            DirectoryInfo directory = new DirectoryInfo(compLoadPath);
            bool found = false;
            string pathToFile = null;
            // Check if the directory exists
            if (directory.Exists)
            {
                // Get all the files in the directory
                FileInfo[] files = directory.GetFiles();

                // Iterate over the files and check if any file name contains the search string
                foreach (FileInfo file in files)
                {
                    if (file.Name.Contains(monthDay))
                    {
                        found = true; // File with the search string exists
                        pathToFile = file.FullName;
                        Console.WriteLine("Location:\n" + pathToFile);
                    }
                }
            }
            else
            {
                Console.WriteLine("Failure - Directory doesn't exist");
                return false;
            }
            if (!found)
            {
                Console.WriteLine("Failure - file with contents not found");
                return false;
            }

            //setup array
            double[] powerReadings = new double[288]; // 288 readings for 24 hours (5-minute intervals)
            // Populate the powerReadings array with zeros initially
            for (int i = 0; i < powerReadings.Length; i++)
            {
                powerReadings[i] = 0.0;
            }

            //read in data
            using(var reader = new StreamReader(pathToFile)) {
                //skip the header
                int index = 0;
                reader.ReadLine();
                while(!reader.EndOfStream) {
                    //get the value all at once
                    try
                    {
                        string datum = reader.ReadLine().Split(',')[3];
                        Console.WriteLine("Read Datum: " + datum);
                        powerReadings[index] = double.Parse(datum);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Issue reading data: " + ex.Message);
                    }
                    index++;
                }
            }

            // Create an array to store the aggregated 30-minute power consumption
            double[] aggregatedPower = new double[48]; // 48 intervals for 24 hours (30-minute intervals)

            // Iterate over the 5-minute readings and aggregate them into 30-minute intervals
            for (int i = 0; i < 288; i++)
            {
                int intervalIndex = i / 6; // Divide the index by 6 to get the corresponding 30-minute interval index

                // Add the 5-minute reading to the corresponding 30-minute interval
                aggregatedPower[intervalIndex] += powerReadings[i];
            }
            //save the aggregatedPower
            comprehensiveLoad[monthDay] = aggregatedPower;
            Console.WriteLine("Success!");
            return true;
        }

        public List<double> GetHourlyConsumptionList()
        {
            if (usesPreLoad)
            {
                return genericLoad;
            }
            try
            {
                const int halfHourCount = 48; // 24 hours * 2 half-hours per hour

                // Calculate the average hourly power consumption based on the items in the factory
                double avgHourlyConsumption = CalculateHourlyPowerConsumption();

                // Create a list to hold the half-hourly consumption values
                List<double> consumptionList = new List<double>(halfHourCount);

                // Calculate the consumption for each half-hour period
                for (int halfHour = 0; halfHour < halfHourCount; halfHour++)
                {
                    // Determine the current hour and minute
                    int hour = halfHour / 2;
                    int minute = (halfHour % 2) * 30;

                    // Check if machinery is being used during this half-hour period
                    double machineryConsumption = 0;
                    foreach (Tuple<string, double> item in machines)
                    {
                        if (IsMachineryBeingUsed(hour, minute, item.Item1))
                        {
                            machineryConsumption += item.Item2;
                        }
                    }

                    // Calculate the total consumption for this half-hour period
                    double totalConsumption = avgHourlyConsumption / 2 + machineryConsumption;

                    // Add the value to the consumption list
                    consumptionList.Add(totalConsumption);
                }

                return consumptionList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        private bool IsMachineryBeingUsed(int hour, int minute, string machineryName)
        {

            // Check if the given machinery is being used during the specified time
            if (machineTimeRanges.ContainsKey(machineryName))
            {
                foreach (Tuple<TimeSpan, TimeSpan> timeRange in machineTimeRanges[machineryName])
                {
                    TimeSpan startTime = timeRange.Item1;
                    TimeSpan endTime = timeRange.Item2;

                    //Dev Notes: potentially re-write messy logic

                    if (hour >= startTime.Hours && hour < endTime.Hours)
                    {
                        // The machinery is being used during the entire hour
                        return true;
                    }
                    else if (hour == startTime.Hours && minute >= startTime.Minutes)
                    {
                        // The machinery is being used during the current half-hour period
                        return true;
                    }
                    else if (hour == endTime.Hours && minute < endTime.Minutes)
                    {
                        // The machinery is being used during the current half-hour period
                        return true;
                    }
                }
            }

            // The machinery is not being used during the specified time
            return false;
        }

        public void AddMachine(string name, double wattage)
        {
            try
            {
                //keeping parity
                machineTimeRanges.Add(name, new List<Tuple<TimeSpan, TimeSpan>>());
                machines.Add(new Tuple<string, double>(name, wattage));

            }
            catch(Exception e)
            {
                Console.WriteLine("There was an error: " + e);
            }
        }

        public void AddMachineTimeRange(string machineName, TimeSpan startTime, TimeSpan endTime)
        {
            if (!machineTimeRanges.ContainsKey(machineName))
            {
                throw new ArgumentException($"No machine exists: '{machineName}'.");
            }
            else
            {
                machineTimeRanges[machineName].Add(new Tuple<TimeSpan, TimeSpan>(startTime, endTime));
                Console.WriteLine("Added: " + startTime.ToString() + " to " + endTime.ToString());
            }
        }

        public void RemoveMachineTimeRange(string machineName, int index)
        {
            if (machineTimeRanges.ContainsKey(machineName) && machineTimeRanges[machineName].Count > index)
            {
                machineTimeRanges[machineName].RemoveAt(index);
            }
            else
            {
                throw new ArgumentException($"No time range with index '{index}' exists for machine '{machineName}'.");
            }
        }

        //The following code handles comprehensive loads
        public void setComprehensiveLoad(string pathToLoad)
        {
            compLoadPath = pathToLoad;
            usesCompLoad = true;
            usesPreLoad = false;
        }

        public void clearComprehensiveLoad()
        {
            compLoadPath = null;
            usesCompLoad = false;
        }

        public override string getArrayDescription()
        {
            return $"Factory Model, {Name}";
        }

        public override int getDailyConsumption()
        {
            throw new NotImplementedException();
        }

        public override int getDailyEmissions()
        {
            throw new NotImplementedException();
        }

        public override string getProductDecription()
        {
            return $"Dairy Factory, {Name}";
        }

        public void setVariableLoad(List<double> load)
        {
            genericLoad = load;
            usesPreLoad = true;
            usesCompLoad = false;
        }

        public void clearVariableLoad()
        {
            genericLoad = new List<double>();
            usesPreLoad = false;
        }

    }
}
