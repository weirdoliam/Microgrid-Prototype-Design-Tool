using System;
using System.Collections.Generic;


namespace WinFormsApp1
{
    class DairyFactory : EnergyOut
    {

        // Properties
        public string Name { get; set; }
        public List<Tuple<string, double>> Machines { get => machines; }
        public Dictionary<string, List<Tuple<TimeSpan, TimeSpan>>> MachineTimeRanges { get => machineTimeRanges; }

        //variable loads per item. 
        //Flexibility in how a load is defined

        // Item Lists. These need to be in sync.
        private List<Tuple<string, double>> machines;
        private Dictionary<string, List<Tuple<TimeSpan, TimeSpan>>> machineTimeRanges = new Dictionary<string, List<Tuple<TimeSpan, TimeSpan>>>();

        //Variable load, and associated bool
        private List<double> predefinedLoad = new List<double>();
        private bool usesPreLoad = false;

        // Constructor
        public DairyFactory(string name)
        {
            Name = name;
            machines = new List<Tuple<string, double>>();
            machineTimeRanges = new Dictionary<string, List<Tuple<TimeSpan, TimeSpan>>>();
        }

        public DairyFactory(string name, List<Tuple<string, double>> machines, Dictionary<string, List<Tuple<TimeSpan, TimeSpan>>> machineTimeRanges, List<double> load, bool preLoaded) : this(name)
        {
            this.machines = machines;
            this.machineTimeRanges = machineTimeRanges;
            this.predefinedLoad = load;
            this.usesPreLoad = preLoaded;
        }

        public DairyFactory Clone() {
            return new DairyFactory(this.Name, this.machines, this.MachineTimeRanges, this.predefinedLoad, this.usesPreLoad);
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

        public List<double> GetHourlyConsumptionList()
        {
            if (usesPreLoad)
            {
                return predefinedLoad;
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

        public override string getArrayDescription()
        {
            return $"Dairy Factory, {Name}";
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
            predefinedLoad = load;
            usesPreLoad = true;
        }

        public void clearVariableLoad()
        {
            predefinedLoad = new List<double>();
            usesPreLoad = false;
        }

    }
}
