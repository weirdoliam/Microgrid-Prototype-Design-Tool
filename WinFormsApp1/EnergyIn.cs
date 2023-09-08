namespace WinFormsApp1
{
    abstract class EnergyIn
    {
        //Daily emmisiosn (if necessary)
        protected int dailyEmissions;
        //watts capacity
        protected int watts;
        //Price of asset
        public decimal Price { get; set; }
        //wattage of asset
        public int Watts { get => watts; }
        //asset may be an array of objects
        protected bool isArray;
        //get daily emissions, which is normally 0 for renewable energy sources. 
        public abstract int getDailyEmissions();
        //Get specific timeseries point (at a time, and point)
        public abstract int getHalfHourlyGeneration(string currTime, int iterationNo);
        //Get generic daily generation
        public abstract int getDailyGeneration();
        //get array description
        public abstract string getArrayDescription();
        //get asset definition
        public abstract string getProductDecription();
    }
}
