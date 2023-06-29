using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Wind
{
    //I think restructure arrays into classes that dont inherit turbines, and also classes that simply store the turbine/energyIn obj as well as amount
    internal class WindTurbineArray : WindTurbine
    {
        protected int amount;
        public int Amount { get => amount; }

        public WindTurbineArray(int watts, int rotorDiameter, int amount, int rotation, string name) :
            base(watts, rotorDiameter, rotation, name)
        {
            this.amount = amount;
            isArray = true;
        }

        public override int getDailyEmissions()
        {
            return base.getDailyEmissions() * amount;
        }

        public override int getDailyGeneration()
        {
            return base.getDailyGeneration() * amount;
        }

        public override string getProductDecription()
        {
            return base.getProductDecription();
        }

        public override string getArrayDescription()
        {
            return "Regular Wind Turbine, " + amount + " units";
        }

        public WindTurbine getWindTurbine()
        {
            return new WindTurbine(watts, rotorDiameter, rotation, name);
        }
    }
}
