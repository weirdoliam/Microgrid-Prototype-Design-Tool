using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.EnergyStorage;
using WinFormsApp1.graphing;
using WinFormsApp1.managers;
using WinFormsApp1.Reporting;
using WinFormsApp1.Solar;
using WinFormsApp1.utilForms;
using WinFormsApp1.Wind;

namespace WinFormsApp1
{

    public partial class MainForm : Form
    {

        //for auto updating
        int updateNum = 0;

        public MainForm()
        {
            // Show the loading form on a separate thread
            LoadingScreenManager.ShowLoadingScreen(new BatteryLoading());


            InitializeComponent();

            //read in sunlight hours
            Console.WriteLine("Main Form Initialized OK");
            var path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "sunrise_times2.csv");
            using (var reader = new StreamReader(path))
            {
                int currMonth = 0;
                //defaults
                DateTime rise = DateTime.Now;
                DateTime set = DateTime.Now;
                TimeSpan daylightHours = TimeSpan.Zero;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    if (values.Length == 1)
                    {
                        currMonth = int.Parse(line);
                    }
                    else
                    {
                        //TimeSpan t = new TimeSpan(hours,mins,secs)
                        int day = int.Parse(values[0]);
                        string[] riseTimes = values[2].Split(":");
                        rise = new DateTime(2022, currMonth, day, int.Parse(riseTimes[0]), int.Parse(riseTimes[1]), 0);

                        string[] setTimes = values[3].Split(":");
                        set = new DateTime(2022, currMonth, day, int.Parse(setTimes[0]) + 12, int.Parse(setTimes[1]), 0);

                        string[] daylightTimes = values[4].Split(":");
                        daylightHours = new TimeSpan(int.Parse(daylightTimes[0]), int.Parse(daylightTimes[1]), 0);

                        Cache.yearSunTimes.Add(new DayRiseTimes(rise, set, daylightHours));
                    }

                }
            }
            //now we set the correct date

            DateTime newDate = DateTime.Now;
            foreach (DayRiseTimes d in Cache.yearSunTimes)
            {
                if (newDate.Day == d.Day && newDate.Month == d.Month)
                {
                    Cache.currDay = d;
                }
            }

            string path2 = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "house\\");
            string[] paths = Directory.GetFiles(path2);

            //read in house models
            for (int i = 0; i < paths.Length; i++)
            {
                using (var reader = new StreamReader(paths[i]))
                {
                    //parse the initial description
                    string[] d = reader.ReadLine().Split(',');
                    HouseModel newHouse = new HouseModel(bool.Parse(d[0]), bool.Parse(d[1]), bool.Parse(d[2]),
                        bool.Parse(d[3]), bool.Parse(d[4]), bool.Parse(d[5]), bool.Parse(d[6]), bool.Parse(d[7]), bool.Parse(d[8]),
                        bool.Parse(d[9]), bool.Parse(d[10]), int.Parse(d[11]), int.Parse(d[12]), d[13], d[14]);
                    //MessageBox.Show("Created House: " + newHouse.ToString());
                    while (!reader.EndOfStream)
                    {

                        string[] values = reader.ReadLine().Split(',');
                        //MessageBox.Show(values[0] + ", " + values[1]);
                        if (values.Length != 2)
                        {
                            string[] isolatedDate = values[0].Split(' ');
                            //reformat to day month year
                            string[] newDateFormat = isolatedDate[0].Split("/");
                            //MessageBox.Show(newDateFormat[0]);
                            int year = 2022;
                            int month = int.Parse(newDateFormat[1]);
                            int day = int.Parse(newDateFormat[2]);
                            string date = day + "/" + month + "/" + year;
                            //MessageBox.Show(date);
                            newHouse.addTimeSample(date, (int)double.Parse(values[1]));
                        }
                        else
                        {
                            //skip
                        }

                    }
                    Cache.houseModels.Add(newHouse);
                }
            }
            //Read in Power Curves and Existing turbine specifications
            //first is turbines
            string turbineSpecPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "wind\\Sample_Turbines.csv");
            using (var reader = new StreamReader(turbineSpecPath))
            {
                //we're skipping the first two lines (they're headers)
                reader.ReadLine();
                reader.ReadLine();
                string line = "";
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] values = line.Split(",");
                    try
                    {
                        WindTurbineExisting wte = new WindTurbineExisting(values[1], values[3], int.Parse(values[8]) * 1000, double.Parse(values[9]),
                            double.Parse(values[10]), int.Parse(values[12]), double.Parse(values[19]), double.Parse(values[20]), double.Parse(values[21]));
                        Cache.availableTurbines.Add(wte);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("LOAD: Can't read in Turbine: " + e.Message);
                    }
                }
            }
            //then power curves
            string curvePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "wind\\Sample_Power_curves.csv");
            using (var reader = new StreamReader(curvePath))
            {
                //we're skipping the first two lines (they're headers)
                reader.ReadLine();
                reader.ReadLine();
                string line;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] values = line.Split(",");
                    try
                    {
                        WindTurbinePowerCurve wtpc = new WindTurbinePowerCurve(values[1], values[3]);
                        //now get all the data points from index positions 4-74 with windspeed starting at 0
                        double windspeed = 0.0;
                        for (int i = 4; i < 75; i++)
                        {
                            wtpc.addDataPoint(windspeed, int.Parse(values[i]) * 1000);
                            windspeed += 0.5;
                        }
                        //loop through our list of generators and associate it to them
                        foreach (EnergyIn en in Cache.availableTurbines)
                        {
                            if (en is WindTurbineExisting)
                            {
                                WindTurbineExisting existing = (WindTurbineExisting)en;
                                if (wtpc.matchesExistingTurbine(existing))
                                {
                                    existing.Curve = wtpc.Curve;
                                }
                            }
                        }
                        //store the curve, just cause
                        Cache.curves.Add(wtpc);
                    }
                    catch (Exception e)
                    {
                        //Console.WriteLine(e.Message);
                    }
                }

            }

            //Add Existing Power Curves to Menu Items
            foreach (WindTurbineExisting w in Cache.availableTurbines)
            {
                specificToolStripMenuItem.DropDownItems.Add(w.getProductDecription(), null, new EventHandler(MenuItemClickHandler));
            }
            //Add house models to menu items
            foreach (HouseModel h in Cache.houseModels)
            {
                houseModelToolStripMenuItem.DropDownItems.Add(h.shortDescription(), null, new EventHandler(HouseModelAdder));
            }
            //Add Months to month thing
            for (int i = 0; i < 12; i++)
            {
                monthToolStripMenuItem.DropDownItems.Add((i + 1) + "", null, new EventHandler(MonthOpener));
            }
            //init stage ended

            //default additions

            //continueing on, general admin setup
            SolarPanelArray s = new SolarPanelArray("Commercial", 1.9812f, 0.9906f, 1000, 72, "Polycrystalline", 1, 100, 4);
            Cache.genListin.Add(s);
            Cache.genListOut.Add(Cache.houseModels[0]);

            // Work is completed or cancelled, so close the loading form
            LoadingScreenManager.HideLoadingScreen();
        }

        private void MonthOpener(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedMonth = (ToolStripMenuItem)sender;
            int month = int.Parse(clickedMonth.Text);
            MonthyReportViewer mForm = new MonthyReportViewer(month);
            mForm.ShowDialog();
        }

        private void HouseModelAdder(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            string name = clickedItem.Text;
            //locate which one was clicked by comparing the name vs product description
            foreach (HouseModel h in Cache.houseModels)
            {
                if (name.Equals(h.shortDescription()))
                {
                    //it's a match :) so add it
                    Cache.genListOut.Add(h);
                    break;
                }
            }
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            // Take some action based on the data in clickedItem
            string name = clickedItem.Text;
            //locate which one was clicked by comparing the name vs product description
            foreach (WindTurbineExisting w in Cache.availableTurbines)
            {
                if (name.Equals(w.getProductDecription()))
                {
                    //it's a match :) so add it
                    Cache.genListin.Add(w);
                    break;
                }
            }
        }

        private void solarPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenArray f = new FormGenArray();
            f.Show();
        }


        private void update()
        {

            //Array Items
            //added Generators
            listBoxAddedGens.Items.Clear();
            int tot = 0;
            foreach (EnergyIn i in Cache.genListin)
            {
                listBoxAddedGens.Items.Add(i.getArrayDescription());
                tot += i.Watts;
            }
            labelGenTot.Text = Cache.genListin.Count.ToString();
            labelGenCapStatic.Text = tot + "";
            //consumers
            int displayed = 0;

            //Houses
            listBoxAddedHouses.Items.Clear();
            listBoxAddedHouses.Items.Add("Factory: " + Cache.mainFactory.Name);
            tot = 0;
            foreach (EnergyOut eOut in Cache.genListOut)
            {
                listBoxAddedHouses.Items.Add(eOut.getProductDecription());
            }
            labelHouseTot.Text = (Cache.genListOut.Count + 1).ToString();

            //Batteries
            listBoxStorage.Items.Clear();
            tot = 0;
            foreach (EnergyStorageUnit eSu in Cache.energyStorageUnits)
            {
                listBoxStorage.Items.Add(eSu.getDescription());
                tot += (int)eSu.Capacity;
            }
            labelStorageTot.Text = Cache.energyStorageUnits.Count.ToString();
            labelCapacity.Text = tot + "";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int currSum = 0;

            currSum += Cache.genListin.Count;
            currSum += Cache.genListOut.Count;
            currSum += Cache.houseModels.Count;
            currSum += Cache.availableTurbines.Count;
            currSum += Cache.energyStorageUnits.Count;
            //This method executes every seccond
            if (currSum != updateNum)
            {
                update();
                updateNum = currSum;
                buttonRemoveGen.Enabled = false;
                buttonRemoveHouse.Enabled = false;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            listBoxAddedGens.SelectedIndex = -1;
            listBoxAddedHouses.SelectedIndex = -1;
            update();
        }

        private void simpleHousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEnergyOutForm f = new AddEnergyOutForm();
            f.ShowDialog();
        }

        private void dailyInsigtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadComparison f = new LoadComparison();
            f.Show();
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDateTime f = new ChangeDateTime();
            f.Show();
        }


        private void listBoxAddedGens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAddedGens.SelectedIndex >= 0) buttonRemoveGen.Enabled = true;
            else buttonRemoveGen.Enabled = false;
        }

        private void listBoxStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStorage.SelectedIndex >= 0) buttonRemoveBattery.Enabled = true;
            else buttonRemoveBattery.Enabled = false;
        }

        private void buttonRemoveGen_Click(object sender, EventArgs e)
        {
            int i = listBoxAddedGens.SelectedIndex;
            listBoxAddedGens.SelectedIndex = -1;
            Cache.genListin.RemoveAt(i);
        }

        private void buttonRemoveBattery_Click(object sender, EventArgs e)
        {
            int i = listBoxStorage.SelectedIndex;
            listBoxStorage.SelectedIndex = -1;
            Cache.energyStorageUnits.RemoveAt(i);
        }

        private void listBoxAddedHouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAddedHouses.SelectedIndex >= 0) buttonRemoveHouse.Enabled = true;
            else buttonRemoveHouse.Enabled = false;
        }

        private void buttonRemoveHouse_Click(object sender, EventArgs e)
        {
            int i = listBoxAddedHouses.SelectedIndex - 1;
            listBoxAddedHouses.SelectedIndex = -1;
            if (i > -1) Cache.genListOut.RemoveAt(i);
        }

        private void weatherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeatherTool w = new WeatherTool();
            w.Show();
        }

        private void factoryConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FactoryConfig f = new FactoryConfig();
            f.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Basically we wan't to write the whole cache out to a file - starting with main items (lists, factory content)

            //energy generation objects
            //public static List<EnergyIn> genListin = new List<EnergyIn>();
            Console.WriteLine("Energy In:");
            foreach (EnergyIn en in Cache.genListin)
            {
                Console.WriteLine(en.getProductDecription());
            }

            //Energy consumer objects
            //public static List<EnergyOut> genListOut = new List<EnergyOut>();
            Console.WriteLine("Energy Out:");
            foreach (EnergyOut eo in Cache.genListOut)
            {
                Console.WriteLine(eo.getProductDecription());
            }

            //The main factory of the application
            //public static FactoryModel mainFactory = new FactoryModel("Default Factory");
            Console.WriteLine("Factory: ");
            Console.WriteLine(Cache.mainFactory.ToString());
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //We want to read a file in and replace the arrays in cache
        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open form and stuff to do daily thingy :))
            DailyReportViewer d = new DailyReportViewer(null);
            d.ShowDialog();
        }

        private void lithiumIonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                Cache.energyStorageUnits.Add(new LithiumIonBattery(2000, 1000, "Test Battery", 500));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (HouseModel h in Cache.houseModels)
            {
                Cache.genListOut.Add(h);
            }
        }

        private void largeScaleStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cache.energyStorageUnits.Add(new LithiumIonBattery(20000, 3500, "Test Battery", 5000));
        }

        private void resetStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cache.energyStorageUnits.Clear();
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a month: 1 = Jan, 12 = Dec");
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBattery addBattery = new AddBattery();
            addBattery.ShowDialog();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.X_Pressed;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.X;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fullYearForecastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YearlyPerformance yp = new YearlyPerformance();
            yp.ShowDialog();
        }
    }
}


