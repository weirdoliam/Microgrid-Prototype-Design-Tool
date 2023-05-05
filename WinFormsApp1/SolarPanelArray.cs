using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class SolarPanelArray : SolarPanel
    {
        int amount;

        public int Amount { get => amount; }

        public SolarPanelArray(string _type, float _width, float _length, int _watts, int _cells, string _material, int amount)
            : base(_type, _width, _length, _watts, _cells, _material)
        {
            this.amount = amount;
            isArray = true;
        }

        public override int getDailyEmissions()
        {
            return base.getDailyEmissions() * amount;
        }

        // in kWh
        public override int getDailyGeneration()
        {
            return base.getDailyGeneration() * amount;
        }

        public override string getArrayDescription()
        {
            return type + " Solar Array, " + amount + " units";
        }

        public SolarPanel getPanelObject() {
            return new SolarPanel(type, width, length, watts, cells, material);
        }
    }
}