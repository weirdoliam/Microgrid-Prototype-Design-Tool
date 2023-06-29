using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Wind
{
    internal class WindTurbinePowerCurve
    {
        private string manufacturer;
        private string name;
        //double being windspeed in m/s and int being kW at that windspeed
        private Dictionary<double, int> curve = new Dictionary<double, int>();

        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Name { get => name; set => name = value; }
        public Dictionary<double, int> Curve { get => curve; set => curve = value; }

        /// <summary>
        /// New power curve
        /// </summary>
        /// <param name="manufacturer">name of manufacturer</param>
        /// <param name="name">model number/name of turbine</param>
        public WindTurbinePowerCurve(string manufacturer, string name)
        {
            this.manufacturer = manufacturer;
            this.name = name;
        }

        public void addDataPoint(double key, int value)
        {
            if (!curve.ContainsKey(key))
            {
                curve.Add(key, value);
            }
            else
            {
                //overwrite value
                curve[key] = value;
            }
        }

        public bool matchesExistingTurbine(WindTurbineExisting e)
        {
            if (e.Manufacturer == manufacturer && e.Name == name)
            {
                return true;
            }
            else return false;
        }
    }
}
