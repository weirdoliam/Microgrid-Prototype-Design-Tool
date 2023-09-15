
namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            generationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            solarPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            consumptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            simpleHousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            houseModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            batteryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lithiumIonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            largeScaleStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            resetStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            specificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            factoryConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            forecastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            generalCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dailyInsigtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            overallAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fullYearForecastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            labelGridAssets = new System.Windows.Forms.Label();
            groupBoxGeneration = new System.Windows.Forms.GroupBox();
            labelGenCap = new System.Windows.Forms.Label();
            labelGenTot = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            labelGenCapStatic = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            listBoxAddedGens = new System.Windows.Forms.ListBox();
            buttonRemoveGen = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBoxConsumption = new System.Windows.Forms.GroupBox();
            labelHouseTot = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            buttonAddAll = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            buttonRemoveHouse = new System.Windows.Forms.Button();
            listBoxAddedHouses = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            labelCapacity = new System.Windows.Forms.Label();
            labelStorageTot = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            buttonRemoveBattery = new System.Windows.Forms.Button();
            listBoxStorage = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            groupBoxGeneration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBoxConsumption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.Azure;
            menuStrip1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, addToolStripMenuItem, toolsToolStripMenuItem, forecastToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1280, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saveScenarioToolStripMenuItem, loadToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // saveScenarioToolStripMenuItem
            // 
            saveScenarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            saveScenarioToolStripMenuItem.Name = "saveScenarioToolStripMenuItem";
            saveScenarioToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            saveScenarioToolStripMenuItem.Text = "Scenario";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { generationToolStripMenuItem, consumptionToolStripMenuItem, batteryToolStripMenuItem, specificToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            addToolStripMenuItem.Text = "&Add";
            // 
            // generationToolStripMenuItem
            // 
            generationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { solarPanelToolStripMenuItem });
            generationToolStripMenuItem.Name = "generationToolStripMenuItem";
            generationToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            generationToolStripMenuItem.Text = "&Generation";
            // 
            // solarPanelToolStripMenuItem
            // 
            solarPanelToolStripMenuItem.Name = "solarPanelToolStripMenuItem";
            solarPanelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            solarPanelToolStripMenuItem.Text = "Solar and Wind";
            solarPanelToolStripMenuItem.Click += solarPanelToolStripMenuItem_Click;
            // 
            // consumptionToolStripMenuItem
            // 
            consumptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { simpleHousesToolStripMenuItem, houseModelToolStripMenuItem });
            consumptionToolStripMenuItem.Name = "consumptionToolStripMenuItem";
            consumptionToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            consumptionToolStripMenuItem.Text = "&Consumption";
            // 
            // simpleHousesToolStripMenuItem
            // 
            simpleHousesToolStripMenuItem.Name = "simpleHousesToolStripMenuItem";
            simpleHousesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            simpleHousesToolStripMenuItem.Text = "Custom House";
            simpleHousesToolStripMenuItem.Click += simpleHousesToolStripMenuItem_Click;
            // 
            // houseModelToolStripMenuItem
            // 
            houseModelToolStripMenuItem.Name = "houseModelToolStripMenuItem";
            houseModelToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            houseModelToolStripMenuItem.Text = "Preloaded House Models";
            // 
            // batteryToolStripMenuItem
            // 
            batteryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { customToolStripMenuItem, lithiumIonToolStripMenuItem, largeScaleStorageToolStripMenuItem, resetStorageToolStripMenuItem });
            batteryToolStripMenuItem.Name = "batteryToolStripMenuItem";
            batteryToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            batteryToolStripMenuItem.Text = "Battery";
            // 
            // customToolStripMenuItem
            // 
            customToolStripMenuItem.Name = "customToolStripMenuItem";
            customToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            customToolStripMenuItem.Text = "Custom";
            customToolStripMenuItem.Click += customToolStripMenuItem_Click;
            // 
            // lithiumIonToolStripMenuItem
            // 
            lithiumIonToolStripMenuItem.Name = "lithiumIonToolStripMenuItem";
            lithiumIonToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            lithiumIonToolStripMenuItem.Text = "Lithium Ion (2kW)";
            lithiumIonToolStripMenuItem.Click += lithiumIonToolStripMenuItem_Click;
            // 
            // largeScaleStorageToolStripMenuItem
            // 
            largeScaleStorageToolStripMenuItem.Name = "largeScaleStorageToolStripMenuItem";
            largeScaleStorageToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            largeScaleStorageToolStripMenuItem.Text = "Large-Scale Storage (20kW)";
            largeScaleStorageToolStripMenuItem.Click += largeScaleStorageToolStripMenuItem_Click;
            // 
            // resetStorageToolStripMenuItem
            // 
            resetStorageToolStripMenuItem.Name = "resetStorageToolStripMenuItem";
            resetStorageToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            resetStorageToolStripMenuItem.Text = "Reset Storage";
            resetStorageToolStripMenuItem.Click += resetStorageToolStripMenuItem_Click;
            // 
            // specificToolStripMenuItem
            // 
            specificToolStripMenuItem.Name = "specificToolStripMenuItem";
            specificToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            specificToolStripMenuItem.Text = "Preloaded &Wind Turbines";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { factoryConfigurationToolStripMenuItem, weatherToolStripMenuItem, dateToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // factoryConfigurationToolStripMenuItem
            // 
            factoryConfigurationToolStripMenuItem.Name = "factoryConfigurationToolStripMenuItem";
            factoryConfigurationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            factoryConfigurationToolStripMenuItem.Text = "Factory Configuration";
            factoryConfigurationToolStripMenuItem.Click += factoryConfigurationToolStripMenuItem_Click;
            // 
            // weatherToolStripMenuItem
            // 
            weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
            weatherToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            weatherToolStripMenuItem.Text = "Weather";
            weatherToolStripMenuItem.Click += weatherToolStripMenuItem_Click;
            // 
            // dateToolStripMenuItem
            // 
            dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            dateToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            dateToolStripMenuItem.Text = "Date";
            dateToolStripMenuItem.Click += dateToolStripMenuItem_Click;
            // 
            // forecastToolStripMenuItem
            // 
            forecastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { generalCaseToolStripMenuItem, dailyInsigtsToolStripMenuItem, overallAnalysisToolStripMenuItem, dayToolStripMenuItem, monthToolStripMenuItem, fullYearForecastToolStripMenuItem });
            forecastToolStripMenuItem.Name = "forecastToolStripMenuItem";
            forecastToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            forecastToolStripMenuItem.Text = "&Model";
            // 
            // generalCaseToolStripMenuItem
            // 
            generalCaseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            generalCaseToolStripMenuItem.Name = "generalCaseToolStripMenuItem";
            generalCaseToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            generalCaseToolStripMenuItem.Text = "Comparison";
            // 
            // dailyInsigtsToolStripMenuItem
            // 
            dailyInsigtsToolStripMenuItem.Name = "dailyInsigtsToolStripMenuItem";
            dailyInsigtsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            dailyInsigtsToolStripMenuItem.Text = "Load Comparison";
            dailyInsigtsToolStripMenuItem.Click += dailyInsigtsToolStripMenuItem_Click;
            // 
            // overallAnalysisToolStripMenuItem
            // 
            overallAnalysisToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            overallAnalysisToolStripMenuItem.Name = "overallAnalysisToolStripMenuItem";
            overallAnalysisToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            overallAnalysisToolStripMenuItem.Text = "Overall Analysis";
            // 
            // dayToolStripMenuItem
            // 
            dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            dayToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            dayToolStripMenuItem.Text = "Current Day";
            dayToolStripMenuItem.Click += dayToolStripMenuItem_Click;
            // 
            // monthToolStripMenuItem
            // 
            monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            monthToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            monthToolStripMenuItem.Text = "Month";
            monthToolStripMenuItem.Click += monthToolStripMenuItem_Click;
            // 
            // fullYearForecastToolStripMenuItem
            // 
            fullYearForecastToolStripMenuItem.Name = "fullYearForecastToolStripMenuItem";
            fullYearForecastToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            fullYearForecastToolStripMenuItem.Text = "Full Year";
            fullYearForecastToolStripMenuItem.Click += fullYearForecastToolStripMenuItem_Click;
            // 
            // labelGridAssets
            // 
            labelGridAssets.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            labelGridAssets.AutoSize = true;
            labelGridAssets.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelGridAssets.Location = new System.Drawing.Point(426, 8);
            labelGridAssets.Name = "labelGridAssets";
            labelGridAssets.Size = new System.Drawing.Size(431, 74);
            labelGridAssets.TabIndex = 13;
            labelGridAssets.Text = "MicroSim Dev";
            // 
            // groupBoxGeneration
            // 
            groupBoxGeneration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            groupBoxGeneration.Controls.Add(labelGenCap);
            groupBoxGeneration.Controls.Add(labelGenTot);
            groupBoxGeneration.Controls.Add(label5);
            groupBoxGeneration.Controls.Add(labelGenCapStatic);
            groupBoxGeneration.Controls.Add(pictureBox2);
            groupBoxGeneration.Controls.Add(listBoxAddedGens);
            groupBoxGeneration.Controls.Add(buttonRemoveGen);
            groupBoxGeneration.Controls.Add(label1);
            groupBoxGeneration.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBoxGeneration.Location = new System.Drawing.Point(4, 6);
            groupBoxGeneration.Name = "groupBoxGeneration";
            groupBoxGeneration.Size = new System.Drawing.Size(352, 527);
            groupBoxGeneration.TabIndex = 15;
            groupBoxGeneration.TabStop = false;
            groupBoxGeneration.Text = "Generation";
            // 
            // labelGenCap
            // 
            labelGenCap.AutoSize = true;
            labelGenCap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelGenCap.Location = new System.Drawing.Point(291, 423);
            labelGenCap.Name = "labelGenCap";
            labelGenCap.Size = new System.Drawing.Size(34, 21);
            labelGenCap.TabIndex = 12;
            labelGenCap.Text = "0W";
            // 
            // labelGenTot
            // 
            labelGenTot.AutoSize = true;
            labelGenTot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelGenTot.Location = new System.Drawing.Point(291, 390);
            labelGenTot.Name = "labelGenTot";
            labelGenTot.Size = new System.Drawing.Size(19, 21);
            labelGenTot.TabIndex = 11;
            labelGenTot.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(9, 390);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(277, 21);
            label5.TabIndex = 10;
            label5.Text = "Total: .......................................................";
            // 
            // labelGenCapStatic
            // 
            labelGenCapStatic.AutoSize = true;
            labelGenCapStatic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelGenCapStatic.Location = new System.Drawing.Point(9, 423);
            labelGenCapStatic.Name = "labelGenCapStatic";
            labelGenCapStatic.Size = new System.Drawing.Size(276, 21);
            labelGenCapStatic.TabIndex = 9;
            labelGenCapStatic.Text = "Estimated Total Wattage: ...............";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.lightning;
            pictureBox2.Location = new System.Drawing.Point(6, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(58, 58);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // listBoxAddedGens
            // 
            listBoxAddedGens.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBoxAddedGens.FormattingEnabled = true;
            listBoxAddedGens.ItemHeight = 17;
            listBoxAddedGens.Location = new System.Drawing.Point(6, 87);
            listBoxAddedGens.Name = "listBoxAddedGens";
            listBoxAddedGens.Size = new System.Drawing.Size(340, 259);
            listBoxAddedGens.TabIndex = 6;
            listBoxAddedGens.SelectedIndexChanged += listBoxAddedGens_SelectedIndexChanged;
            // 
            // buttonRemoveGen
            // 
            buttonRemoveGen.Enabled = false;
            buttonRemoveGen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRemoveGen.Location = new System.Drawing.Point(6, 352);
            buttonRemoveGen.Name = "buttonRemoveGen";
            buttonRemoveGen.Size = new System.Drawing.Size(69, 25);
            buttonRemoveGen.TabIndex = 7;
            buttonRemoveGen.Text = "Remove";
            buttonRemoveGen.UseVisualStyleBackColor = true;
            buttonRemoveGen.Click += buttonRemoveGen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(70, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(229, 28);
            label1.TabIndex = 3;
            label1.Text = "Added Generators";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // groupBoxConsumption
            // 
            groupBoxConsumption.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            groupBoxConsumption.Controls.Add(labelHouseTot);
            groupBoxConsumption.Controls.Add(label6);
            groupBoxConsumption.Controls.Add(buttonAddAll);
            groupBoxConsumption.Controls.Add(pictureBox3);
            groupBoxConsumption.Controls.Add(buttonRemoveHouse);
            groupBoxConsumption.Controls.Add(listBoxAddedHouses);
            groupBoxConsumption.Controls.Add(label2);
            groupBoxConsumption.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBoxConsumption.Location = new System.Drawing.Point(457, 3);
            groupBoxConsumption.Name = "groupBoxConsumption";
            groupBoxConsumption.Size = new System.Drawing.Size(351, 527);
            groupBoxConsumption.TabIndex = 16;
            groupBoxConsumption.TabStop = false;
            groupBoxConsumption.Text = "Consumption";
            // 
            // labelHouseTot
            // 
            labelHouseTot.AutoSize = true;
            labelHouseTot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelHouseTot.Location = new System.Drawing.Point(289, 390);
            labelHouseTot.Name = "labelHouseTot";
            labelHouseTot.Size = new System.Drawing.Size(19, 21);
            labelHouseTot.TabIndex = 13;
            labelHouseTot.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(6, 390);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(277, 21);
            label6.TabIndex = 11;
            label6.Text = "Total: .......................................................";
            // 
            // buttonAddAll
            // 
            buttonAddAll.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAddAll.Location = new System.Drawing.Point(288, 352);
            buttonAddAll.Name = "buttonAddAll";
            buttonAddAll.Size = new System.Drawing.Size(58, 25);
            buttonAddAll.TabIndex = 10;
            buttonAddAll.Text = "Add All";
            buttonAddAll.UseVisualStyleBackColor = true;
            buttonAddAll.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.house;
            pictureBox3.Location = new System.Drawing.Point(6, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(58, 58);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // buttonRemoveHouse
            // 
            buttonRemoveHouse.Enabled = false;
            buttonRemoveHouse.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRemoveHouse.Location = new System.Drawing.Point(6, 352);
            buttonRemoveHouse.Name = "buttonRemoveHouse";
            buttonRemoveHouse.Size = new System.Drawing.Size(61, 25);
            buttonRemoveHouse.TabIndex = 9;
            buttonRemoveHouse.Text = "Remove";
            buttonRemoveHouse.UseVisualStyleBackColor = true;
            buttonRemoveHouse.Click += buttonRemoveHouse_Click;
            // 
            // listBoxAddedHouses
            // 
            listBoxAddedHouses.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBoxAddedHouses.FormattingEnabled = true;
            listBoxAddedHouses.ItemHeight = 17;
            listBoxAddedHouses.Location = new System.Drawing.Point(6, 87);
            listBoxAddedHouses.Name = "listBoxAddedHouses";
            listBoxAddedHouses.Size = new System.Drawing.Size(340, 259);
            listBoxAddedHouses.TabIndex = 7;
            listBoxAddedHouses.SelectedIndexChanged += listBoxAddedHouses_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(70, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(263, 28);
            label2.TabIndex = 4;
            label2.Text = "Added House Models";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.otherAssets;
            pictureBox1.Location = new System.Drawing.Point(331, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(89, 88);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(labelGridAssets);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1280, 91);
            panel1.TabIndex = 19;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pictureBox5.Image = Properties.Resources.X;
            pictureBox5.Location = new System.Drawing.Point(1237, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(20, 20);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            pictureBox5.MouseEnter += pictureBox5_MouseEnter;
            pictureBox5.MouseLeave += pictureBox5_MouseLeave;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBoxConsumption);
            panel2.Controls.Add(groupBoxGeneration);
            panel2.Location = new System.Drawing.Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1280, 608);
            panel2.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            groupBox1.Controls.Add(labelCapacity);
            groupBox1.Controls.Add(labelStorageTot);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(buttonRemoveBattery);
            groupBox1.Controls.Add(listBoxStorage);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(904, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(351, 527);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Storage";
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCapacity.Location = new System.Drawing.Point(289, 423);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new System.Drawing.Size(34, 21);
            labelCapacity.TabIndex = 14;
            labelCapacity.Text = "0W";
            // 
            // labelStorageTot
            // 
            labelStorageTot.AutoSize = true;
            labelStorageTot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelStorageTot.Location = new System.Drawing.Point(289, 390);
            labelStorageTot.Name = "labelStorageTot";
            labelStorageTot.Size = new System.Drawing.Size(19, 21);
            labelStorageTot.TabIndex = 13;
            labelStorageTot.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(6, 390);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(277, 21);
            label7.TabIndex = 12;
            label7.Text = "Total: .......................................................";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(6, 423);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(278, 21);
            label4.TabIndex = 10;
            label4.Text = "Estimated Total Capacity: ...............";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(6, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(58, 58);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // buttonRemoveBattery
            // 
            buttonRemoveBattery.Enabled = false;
            buttonRemoveBattery.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRemoveBattery.Location = new System.Drawing.Point(6, 352);
            buttonRemoveBattery.Name = "buttonRemoveBattery";
            buttonRemoveBattery.Size = new System.Drawing.Size(67, 25);
            buttonRemoveBattery.TabIndex = 9;
            buttonRemoveBattery.Text = "Remove";
            buttonRemoveBattery.UseVisualStyleBackColor = true;
            buttonRemoveBattery.Click += buttonRemoveBattery_Click;
            // 
            // listBoxStorage
            // 
            listBoxStorage.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBoxStorage.FormattingEnabled = true;
            listBoxStorage.ItemHeight = 17;
            listBoxStorage.Location = new System.Drawing.Point(6, 87);
            listBoxStorage.Name = "listBoxStorage";
            listBoxStorage.Size = new System.Drawing.Size(340, 259);
            listBoxStorage.TabIndex = 7;
            listBoxStorage.SelectedIndexChanged += listBoxStorage_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(70, 37);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(187, 28);
            label3.TabIndex = 4;
            label3.Text = "Energy Storage";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            ClientSize = new System.Drawing.Size(1280, 728);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Isolated Systems Design Analysis";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Click += Form1_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxGeneration.ResumeLayout(false);
            groupBoxGeneration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBoxConsumption.ResumeLayout(false);
            groupBoxConsumption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forecastToolStripMenuItem;
        private System.Windows.Forms.Label labelGridAssets;
        private System.Windows.Forms.ToolStripMenuItem generationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solarPanelToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxGeneration;
        private System.Windows.Forms.ToolStripMenuItem generalCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullYearForecastToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxConsumption;
        private System.Windows.Forms.ToolStripMenuItem consumptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleHousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyInsigtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherToolStripMenuItem;
        private System.Windows.Forms.Button buttonRemoveGen;
        private System.Windows.Forms.ListBox listBoxAddedGens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAddedHouses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemoveHouse;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specificToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem houseModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factoryConfigurationToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem saveScenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private Nevron.Nov.Windows.Forms.NNovChildWindowHost nNovChildWindowHost1;
        private System.Windows.Forms.ToolStripMenuItem overallAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batteryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lithiumIonToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.ToolStripMenuItem largeScaleStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonRemoveBattery;
        private System.Windows.Forms.ListBox listBoxStorage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelGenCap;
        private System.Windows.Forms.Label labelGenTot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGenCapStatic;
        private System.Windows.Forms.Label labelHouseTot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelStorageTot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}

