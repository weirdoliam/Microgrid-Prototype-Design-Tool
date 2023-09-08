
namespace WinFormsApp1
{
    internal abstract class EnergyOut
    {
        //in something..
        protected int dailyEmissions;
        //watts
        //protected int dailyGeneration;

        //watts capacity
        protected int watts;

        //Return the generic daily emissions
        public abstract int getDailyEmissions();

        //Return the generic daily consumption
        public abstract int getDailyConsumption();

        //Return the description of potential array
        public abstract string getArrayDescription();

        //Return the desciption of the "product" 
        public abstract string getProductDecription();
    }
}

