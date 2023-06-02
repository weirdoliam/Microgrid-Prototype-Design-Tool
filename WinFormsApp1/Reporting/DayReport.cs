using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsApp1.Reporting
{
    internal class DayReport
    {
        public List<int> Consumption { get; set; }
        public List<int> Generation { get; set; }
        public List<int> BatteryCharge { get; set; }
        public List<int> GridNeeds { get; set; }

        public int TotalConsumption => Consumption.Sum();
        public int TotalGeneration => Generation.Sum();
        public int PowerFromGrid => GridNeeds.Sum();
       
        public DayReport(List<int> consumption, List<int> generation, List<int> batteryCharge, List<int> gridNeeds)
        {
            Consumption = consumption;
            Generation = generation;
            BatteryCharge = batteryCharge;
            GridNeeds = gridNeeds;
        }
        /// <summary>
        /// Get the largest value in the report
        /// </summary>
        /// <returns>The largest value in all lists (W)</returns>
        public int Max()
        {
            List<int> contenders = new List<int>();
            contenders.Add(Generation.Max());
            contenders.Add(Consumption.Max());
            contenders.Add(BatteryCharge.Max());
            contenders.Add(GridNeeds.Max());
            return contenders.Max();
        }
    }
}
