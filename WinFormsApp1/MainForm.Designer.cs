
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
            specificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            consumptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            simpleHousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            houseModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            batteryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lithiumIonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            largeScaleStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            resetStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            pictureBox2 = new System.Windows.Forms.PictureBox();
            listBoxAddedGens = new System.Windows.Forms.ListBox();
            buttonRemoveGen = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBoxConsumption = new System.Windows.Forms.GroupBox();
            button1 = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            buttonRemoveHouse = new System.Windows.Forms.Button();
            listBoxAddedHouses = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            labelFactName = new System.Windows.Forms.Label();
            customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            groupBoxGeneration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBoxConsumption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.Azure;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, addToolStripMenuItem, toolsToolStripMenuItem, forecastToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1264, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saveScenarioToolStripMenuItem, loadToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // saveScenarioToolStripMenuItem
            // 
            saveScenarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            saveScenarioToolStripMenuItem.Name = "saveScenarioToolStripMenuItem";
            saveScenarioToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            saveScenarioToolStripMenuItem.Text = "Scenario";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { generationToolStripMenuItem, specificToolStripMenuItem, consumptionToolStripMenuItem, batteryToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            addToolStripMenuItem.Text = "&Add";
            // 
            // generationToolStripMenuItem
            // 
            generationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { solarPanelToolStripMenuItem });
            generationToolStripMenuItem.Name = "generationToolStripMenuItem";
            generationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            generationToolStripMenuItem.Text = "&Solar";
            // 
            // solarPanelToolStripMenuItem
            // 
            solarPanelToolStripMenuItem.Name = "solarPanelToolStripMenuItem";
            solarPanelToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            solarPanelToolStripMenuItem.Text = "G&eneral";
            solarPanelToolStripMenuItem.Click += solarPanelToolStripMenuItem_Click;
            // 
            // specificToolStripMenuItem
            // 
            specificToolStripMenuItem.Name = "specificToolStripMenuItem";
            specificToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            specificToolStripMenuItem.Text = "&Wind";
            // 
            // consumptionToolStripMenuItem
            // 
            consumptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { simpleHousesToolStripMenuItem, houseModelToolStripMenuItem });
            consumptionToolStripMenuItem.Name = "consumptionToolStripMenuItem";
            consumptionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            consumptionToolStripMenuItem.Text = "&Consumption";
            // 
            // simpleHousesToolStripMenuItem
            // 
            simpleHousesToolStripMenuItem.Name = "simpleHousesToolStripMenuItem";
            simpleHousesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            simpleHousesToolStripMenuItem.Text = "Simple House(s)";
            simpleHousesToolStripMenuItem.Click += simpleHousesToolStripMenuItem_Click;
            // 
            // houseModelToolStripMenuItem
            // 
            houseModelToolStripMenuItem.Name = "houseModelToolStripMenuItem";
            houseModelToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            houseModelToolStripMenuItem.Text = "House Model";
            // 
            // batteryToolStripMenuItem
            // 
            batteryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { customToolStripMenuItem, lithiumIonToolStripMenuItem, largeScaleStorageToolStripMenuItem, resetStorageToolStripMenuItem });
            batteryToolStripMenuItem.Name = "batteryToolStripMenuItem";
            batteryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            batteryToolStripMenuItem.Text = "Battery";
            // 
            // lithiumIonToolStripMenuItem
            // 
            lithiumIonToolStripMenuItem.Name = "lithiumIonToolStripMenuItem";
            lithiumIonToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            lithiumIonToolStripMenuItem.Text = "Lithium Ion (2kW)";
            lithiumIonToolStripMenuItem.Click += lithiumIonToolStripMenuItem_Click;
            // 
            // largeScaleStorageToolStripMenuItem
            // 
            largeScaleStorageToolStripMenuItem.Name = "largeScaleStorageToolStripMenuItem";
            largeScaleStorageToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            largeScaleStorageToolStripMenuItem.Text = "Large-Scale Storage (20kW)";
            largeScaleStorageToolStripMenuItem.Click += largeScaleStorageToolStripMenuItem_Click;
            // 
            // resetStorageToolStripMenuItem
            // 
            resetStorageToolStripMenuItem.Name = "resetStorageToolStripMenuItem";
            resetStorageToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            resetStorageToolStripMenuItem.Text = "Reset Storage";
            resetStorageToolStripMenuItem.Click += resetStorageToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { factoryConfigurationToolStripMenuItem, weatherToolStripMenuItem, dateToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
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
            forecastToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            forecastToolStripMenuItem.Text = "&Model";
            // 
            // generalCaseToolStripMenuItem
            // 
            generalCaseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            generalCaseToolStripMenuItem.Name = "generalCaseToolStripMenuItem";
            generalCaseToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            generalCaseToolStripMenuItem.Text = "Comparison";
            // 
            // dailyInsigtsToolStripMenuItem
            // 
            dailyInsigtsToolStripMenuItem.Name = "dailyInsigtsToolStripMenuItem";
            dailyInsigtsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            dailyInsigtsToolStripMenuItem.Text = "Daily Analysis";
            dailyInsigtsToolStripMenuItem.Click += dailyInsigtsToolStripMenuItem_Click;
            // 
            // overallAnalysisToolStripMenuItem
            // 
            overallAnalysisToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            overallAnalysisToolStripMenuItem.Name = "overallAnalysisToolStripMenuItem";
            overallAnalysisToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            overallAnalysisToolStripMenuItem.Text = "Overall Analysis";
            // 
            // dayToolStripMenuItem
            // 
            dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            dayToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            dayToolStripMenuItem.Text = "Day";
            dayToolStripMenuItem.Click += dayToolStripMenuItem_Click;
            // 
            // monthToolStripMenuItem
            // 
            monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            monthToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            monthToolStripMenuItem.Text = "Month";
            monthToolStripMenuItem.Click += monthToolStripMenuItem_Click;
            // 
            // fullYearForecastToolStripMenuItem
            // 
            fullYearForecastToolStripMenuItem.Name = "fullYearForecastToolStripMenuItem";
            fullYearForecastToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            fullYearForecastToolStripMenuItem.Text = "Full Year";
            // 
            // labelGridAssets
            // 
            labelGridAssets.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelGridAssets.AutoSize = true;
            labelGridAssets.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelGridAssets.Location = new System.Drawing.Point(503, 6);
            labelGridAssets.Name = "labelGridAssets";
            labelGridAssets.Size = new System.Drawing.Size(394, 74);
            labelGridAssets.TabIndex = 13;
            labelGridAssets.Text = "MEDA Assets";
            // 
            // groupBoxGeneration
            // 
            groupBoxGeneration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            groupBoxGeneration.Controls.Add(pictureBox2);
            groupBoxGeneration.Controls.Add(listBoxAddedGens);
            groupBoxGeneration.Controls.Add(buttonRemoveGen);
            groupBoxGeneration.Controls.Add(label1);
            groupBoxGeneration.Location = new System.Drawing.Point(18, 121);
            groupBoxGeneration.Name = "groupBoxGeneration";
            groupBoxGeneration.Size = new System.Drawing.Size(352, 539);
            groupBoxGeneration.TabIndex = 15;
            groupBoxGeneration.TabStop = false;
            groupBoxGeneration.Text = "Generation";
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
            listBoxAddedGens.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBoxAddedGens.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBoxAddedGens.FormattingEnabled = true;
            listBoxAddedGens.ItemHeight = 15;
            listBoxAddedGens.Location = new System.Drawing.Point(6, 87);
            listBoxAddedGens.Name = "listBoxAddedGens";
            listBoxAddedGens.Size = new System.Drawing.Size(340, 409);
            listBoxAddedGens.TabIndex = 6;
            listBoxAddedGens.SelectedIndexChanged += listBoxAddedGens_SelectedIndexChanged;
            // 
            // buttonRemoveGen
            // 
            buttonRemoveGen.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            buttonRemoveGen.Enabled = false;
            buttonRemoveGen.Location = new System.Drawing.Point(6, 508);
            buttonRemoveGen.Name = "buttonRemoveGen";
            buttonRemoveGen.Size = new System.Drawing.Size(58, 25);
            buttonRemoveGen.TabIndex = 7;
            buttonRemoveGen.Text = "Remove";
            buttonRemoveGen.UseVisualStyleBackColor = true;
            buttonRemoveGen.Click += buttonRemoveGen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(70, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(240, 29);
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
            groupBoxConsumption.Controls.Add(button1);
            groupBoxConsumption.Controls.Add(pictureBox3);
            groupBoxConsumption.Controls.Add(buttonRemoveHouse);
            groupBoxConsumption.Controls.Add(listBoxAddedHouses);
            groupBoxConsumption.Controls.Add(label2);
            groupBoxConsumption.Location = new System.Drawing.Point(897, 121);
            groupBoxConsumption.Name = "groupBoxConsumption";
            groupBoxConsumption.Size = new System.Drawing.Size(351, 539);
            groupBoxConsumption.TabIndex = 16;
            groupBoxConsumption.TabStop = false;
            groupBoxConsumption.Text = "Consumption";
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button1.Location = new System.Drawing.Point(288, 508);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(58, 25);
            button1.TabIndex = 10;
            button1.Text = "Add All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            buttonRemoveHouse.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            buttonRemoveHouse.Enabled = false;
            buttonRemoveHouse.Location = new System.Drawing.Point(6, 508);
            buttonRemoveHouse.Name = "buttonRemoveHouse";
            buttonRemoveHouse.Size = new System.Drawing.Size(58, 25);
            buttonRemoveHouse.TabIndex = 9;
            buttonRemoveHouse.Text = "Remove";
            buttonRemoveHouse.UseVisualStyleBackColor = true;
            buttonRemoveHouse.Click += buttonRemoveHouse_Click;
            // 
            // listBoxAddedHouses
            // 
            listBoxAddedHouses.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBoxAddedHouses.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBoxAddedHouses.FormattingEnabled = true;
            listBoxAddedHouses.ItemHeight = 15;
            listBoxAddedHouses.Location = new System.Drawing.Point(6, 87);
            listBoxAddedHouses.Name = "listBoxAddedHouses";
            listBoxAddedHouses.Size = new System.Drawing.Size(340, 409);
            listBoxAddedHouses.TabIndex = 7;
            listBoxAddedHouses.SelectedIndexChanged += listBoxAddedHouses_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(70, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(275, 29);
            label2.TabIndex = 4;
            label2.Text = "Added House Models";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.otherAssets;
            pictureBox1.Location = new System.Drawing.Point(370, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(89, 88);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox4.Image = Properties.Resources.factory;
            pictureBox4.Location = new System.Drawing.Point(370, 130);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(527, 530);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel1.Controls.Add(labelGridAssets);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1264, 91);
            panel1.TabIndex = 19;
            // 
            // labelFactName
            // 
            labelFactName.AutoSize = true;
            labelFactName.BackColor = System.Drawing.Color.White;
            labelFactName.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelFactName.Location = new System.Drawing.Point(376, 143);
            labelFactName.Name = "labelFactName";
            labelFactName.Size = new System.Drawing.Size(183, 29);
            labelFactName.TabIndex = 9;
            labelFactName.Text = "factory_name";
            // 
            // customToolStripMenuItem
            // 
            customToolStripMenuItem.Name = "customToolStripMenuItem";
            customToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            customToolStripMenuItem.Text = "Custom";
            customToolStripMenuItem.Click += customToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(labelFactName);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(groupBoxConsumption);
            Controls.Add(groupBoxGeneration);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            Text = "Microgrid Exploration and Design Analysis";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFactName;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem largeScaleStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
    }
}

