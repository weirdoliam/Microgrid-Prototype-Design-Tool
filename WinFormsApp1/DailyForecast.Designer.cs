namespace WinFormsApp1
{
    partial class DailyForecast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelCurrDay = new System.Windows.Forms.Label();
            listBoxModelHouses = new System.Windows.Forms.ListBox();
            canvas = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            checkBoxAverage = new System.Windows.Forms.CheckBox();
            labelPanel = new System.Windows.Forms.Panel();
            checkBoxSmooth = new System.Windows.Forms.CheckBox();
            panelElectric = new System.Windows.Forms.Panel();
            panelMains = new System.Windows.Forms.Panel();
            panelOther = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            labelAverageDaily = new System.Windows.Forms.Label();
            radioButtonOne = new System.Windows.Forms.RadioButton();
            radioButtonAll = new System.Windows.Forms.RadioButton();
            listBoxGenerators = new System.Windows.Forms.ListBox();
            labelSunrise = new System.Windows.Forms.Label();
            labelSunset = new System.Windows.Forms.Label();
            checkBoxArrayTotal = new System.Windows.Forms.CheckBox();
            labelMissingData = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            updateTimer = new System.Windows.Forms.Timer(components);
            checkBoxFactoyLoad = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            labelConsume = new System.Windows.Forms.Label();
            labelGenerate = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            labelNet = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // labelCurrDay
            // 
            labelCurrDay.AutoSize = true;
            labelCurrDay.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCurrDay.Location = new System.Drawing.Point(3, 4);
            labelCurrDay.Name = "labelCurrDay";
            labelCurrDay.Size = new System.Drawing.Size(70, 37);
            labelCurrDay.TabIndex = 1;
            labelCurrDay.Text = "date";
            // 
            // listBoxModelHouses
            // 
            listBoxModelHouses.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            listBoxModelHouses.ForeColor = System.Drawing.Color.Red;
            listBoxModelHouses.FormattingEnabled = true;
            listBoxModelHouses.ItemHeight = 15;
            listBoxModelHouses.Location = new System.Drawing.Point(568, 2);
            listBoxModelHouses.Name = "listBoxModelHouses";
            listBoxModelHouses.Size = new System.Drawing.Size(357, 64);
            listBoxModelHouses.TabIndex = 2;
            listBoxModelHouses.SelectedIndexChanged += listBoxModelHouses_SelectedIndexChanged;
            // 
            // canvas
            // 
            canvas.BackColor = System.Drawing.SystemColors.ControlLight;
            canvas.Location = new System.Drawing.Point(251, 97);
            canvas.Name = "canvas";
            canvas.Size = new System.Drawing.Size(674, 300);
            canvas.TabIndex = 4;
            canvas.Paint += panel1_Paint;
            canvas.MouseClick += canvas_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(234, 402);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "12:00am";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(903, 402);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "11:30pm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(572, 402);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 15);
            label4.TabIndex = 7;
            label4.Text = "12:00pm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(406, 402);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 15);
            label5.TabIndex = 8;
            label5.Text = "6:00am";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(745, 402);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 15);
            label6.TabIndex = 9;
            label6.Text = "6:00pm";
            // 
            // checkBoxAverage
            // 
            checkBoxAverage.AutoSize = true;
            checkBoxAverage.Location = new System.Drawing.Point(27, 94);
            checkBoxAverage.Name = "checkBoxAverage";
            checkBoxAverage.Size = new System.Drawing.Size(98, 19);
            checkBoxAverage.TabIndex = 10;
            checkBoxAverage.Text = "Daily Average";
            checkBoxAverage.UseVisualStyleBackColor = true;
            checkBoxAverage.CheckedChanged += checkBoxAverage_CheckedChanged;
            // 
            // labelPanel
            // 
            labelPanel.BackColor = System.Drawing.SystemColors.Control;
            labelPanel.Location = new System.Drawing.Point(211, 97);
            labelPanel.Name = "labelPanel";
            labelPanel.Size = new System.Drawing.Size(40, 300);
            labelPanel.TabIndex = 11;
            labelPanel.Paint += panel1_Paint_1;
            // 
            // checkBoxSmooth
            // 
            checkBoxSmooth.AutoSize = true;
            checkBoxSmooth.Location = new System.Drawing.Point(211, 72);
            checkBoxSmooth.Name = "checkBoxSmooth";
            checkBoxSmooth.Size = new System.Drawing.Size(102, 19);
            checkBoxSmooth.TabIndex = 12;
            checkBoxSmooth.Text = "Smooth Curve";
            checkBoxSmooth.UseVisualStyleBackColor = true;
            checkBoxSmooth.CheckedChanged += checkBoxSmooth_CheckedChanged;
            // 
            // panelElectric
            // 
            panelElectric.Location = new System.Drawing.Point(8, 195);
            panelElectric.Name = "panelElectric";
            panelElectric.Size = new System.Drawing.Size(200, 40);
            panelElectric.TabIndex = 13;
            // 
            // panelMains
            // 
            panelMains.Location = new System.Drawing.Point(8, 264);
            panelMains.Name = "panelMains";
            panelMains.Size = new System.Drawing.Size(200, 40);
            panelMains.TabIndex = 14;
            // 
            // panelOther
            // 
            panelOther.Location = new System.Drawing.Point(8, 333);
            panelOther.Name = "panelOther";
            panelOther.Size = new System.Drawing.Size(200, 40);
            panelOther.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(8, 177);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(127, 15);
            label7.TabIndex = 16;
            label7.Text = "Electric Consumption: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(8, 246);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(143, 15);
            label8.TabIndex = 17;
            label8.Text = "Mains Gas Consumption: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(8, 315);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(119, 15);
            label9.TabIndex = 18;
            label9.Text = "Other Consumption: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(8, 381);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(197, 15);
            label10.TabIndex = 19;
            label10.Text = "Average Daily Comsumption (kWh):";
            // 
            // labelAverageDaily
            // 
            labelAverageDaily.AutoSize = true;
            labelAverageDaily.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelAverageDaily.Location = new System.Drawing.Point(64, 408);
            labelAverageDaily.Name = "labelAverageDaily";
            labelAverageDaily.Size = new System.Drawing.Size(63, 25);
            labelAverageDaily.TabIndex = 20;
            labelAverageDaily.Text = "0 kWh";
            // 
            // radioButtonOne
            // 
            radioButtonOne.AutoSize = true;
            radioButtonOne.Location = new System.Drawing.Point(12, 69);
            radioButtonOne.Name = "radioButtonOne";
            radioButtonOne.Size = new System.Drawing.Size(105, 19);
            radioButtonOne.TabIndex = 21;
            radioButtonOne.TabStop = true;
            radioButtonOne.Text = "Current Item(s)";
            radioButtonOne.UseVisualStyleBackColor = true;
            radioButtonOne.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Location = new System.Drawing.Point(12, 44);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new System.Drawing.Size(71, 19);
            radioButtonAll.TabIndex = 22;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "All Items";
            radioButtonAll.UseVisualStyleBackColor = true;
            radioButtonAll.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // listBoxGenerators
            // 
            listBoxGenerators.BackColor = System.Drawing.SystemColors.WindowText;
            listBoxGenerators.ForeColor = System.Drawing.Color.YellowGreen;
            listBoxGenerators.FormattingEnabled = true;
            listBoxGenerators.ItemHeight = 15;
            listBoxGenerators.Location = new System.Drawing.Point(211, 2);
            listBoxGenerators.Name = "listBoxGenerators";
            listBoxGenerators.Size = new System.Drawing.Size(353, 64);
            listBoxGenerators.TabIndex = 23;
            listBoxGenerators.SelectedIndexChanged += listBoxGenerators_SelectedIndexChanged;
            // 
            // labelSunrise
            // 
            labelSunrise.AutoSize = true;
            labelSunrise.Location = new System.Drawing.Point(434, 72);
            labelSunrise.Name = "labelSunrise";
            labelSunrise.Size = new System.Drawing.Size(44, 15);
            labelSunrise.TabIndex = 24;
            labelSunrise.Text = "sunrise";
            // 
            // labelSunset
            // 
            labelSunset.AutoSize = true;
            labelSunset.Location = new System.Drawing.Point(750, 72);
            labelSunset.Name = "labelSunset";
            labelSunset.Size = new System.Drawing.Size(41, 15);
            labelSunset.TabIndex = 25;
            labelSunset.Text = "sunset";
            // 
            // checkBoxArrayTotal
            // 
            checkBoxArrayTotal.AutoSize = true;
            checkBoxArrayTotal.Location = new System.Drawing.Point(27, 119);
            checkBoxArrayTotal.Name = "checkBoxArrayTotal";
            checkBoxArrayTotal.Size = new System.Drawing.Size(108, 19);
            checkBoxArrayTotal.TabIndex = 26;
            checkBoxArrayTotal.Text = "Total gen arrays";
            checkBoxArrayTotal.UseVisualStyleBackColor = true;
            checkBoxArrayTotal.CheckedChanged += checkBoxArrayTotal_CheckedChanged;
            // 
            // labelMissingData
            // 
            labelMissingData.AutoSize = true;
            labelMissingData.Location = new System.Drawing.Point(8, 433);
            labelMissingData.Name = "labelMissingData";
            labelMissingData.Size = new System.Drawing.Size(0, 15);
            labelMissingData.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(384, 72);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(51, 15);
            label11.TabIndex = 28;
            label11.Text = "Sunrise: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(701, 72);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(48, 15);
            label12.TabIndex = 29;
            label12.Text = "Sunset: ";
            // 
            // updateTimer
            // 
            updateTimer.Enabled = true;
            updateTimer.Tick += updateTimer_Tick;
            // 
            // checkBoxFactoyLoad
            // 
            checkBoxFactoyLoad.AutoSize = true;
            checkBoxFactoyLoad.Location = new System.Drawing.Point(8, 144);
            checkBoxFactoyLoad.Name = "checkBoxFactoyLoad";
            checkBoxFactoyLoad.Size = new System.Drawing.Size(137, 19);
            checkBoxFactoyLoad.TabIndex = 30;
            checkBoxFactoyLoad.Text = "Overlay Factory Load";
            checkBoxFactoyLoad.UseVisualStyleBackColor = true;
            checkBoxFactoyLoad.CheckedChanged += checkBoxFactoyLoad_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(8, 448);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(243, 28);
            label1.TabIndex = 31;
            label1.Text = "Total energy consumption:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(8, 491);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(223, 28);
            label13.TabIndex = 32;
            label13.Text = "Total energy generation:";
            // 
            // labelConsume
            // 
            labelConsume.AutoSize = true;
            labelConsume.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelConsume.Location = new System.Drawing.Point(267, 448);
            labelConsume.Name = "labelConsume";
            labelConsume.Size = new System.Drawing.Size(52, 28);
            labelConsume.TabIndex = 33;
            labelConsume.Text = "cons";
            // 
            // labelGenerate
            // 
            labelGenerate.AutoSize = true;
            labelGenerate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelGenerate.Location = new System.Drawing.Point(267, 491);
            labelGenerate.Name = "labelGenerate";
            labelGenerate.Size = new System.Drawing.Size(45, 28);
            labelGenerate.TabIndex = 34;
            labelGenerate.Text = "gen";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(381, 471);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(127, 28);
            label14.TabIndex = 35;
            label14.Text = "Net for date: ";
            // 
            // labelNet
            // 
            labelNet.AutoSize = true;
            labelNet.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelNet.ForeColor = System.Drawing.Color.IndianRed;
            labelNet.Location = new System.Drawing.Point(514, 471);
            labelNet.Name = "labelNet";
            labelNet.Size = new System.Drawing.Size(40, 28);
            labelNet.TabIndex = 36;
            labelNet.Text = "net";
            // 
            // DailyForecast
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(963, 528);
            Controls.Add(labelNet);
            Controls.Add(label14);
            Controls.Add(labelGenerate);
            Controls.Add(labelConsume);
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(checkBoxFactoyLoad);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(labelMissingData);
            Controls.Add(checkBoxArrayTotal);
            Controls.Add(labelSunset);
            Controls.Add(labelSunrise);
            Controls.Add(listBoxGenerators);
            Controls.Add(radioButtonAll);
            Controls.Add(radioButtonOne);
            Controls.Add(labelAverageDaily);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panelOther);
            Controls.Add(panelMains);
            Controls.Add(panelElectric);
            Controls.Add(checkBoxSmooth);
            Controls.Add(labelPanel);
            Controls.Add(checkBoxAverage);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(canvas);
            Controls.Add(listBoxModelHouses);
            Controls.Add(labelCurrDay);
            Name = "DailyForecast";
            Text = "Daily Analysis";
            Paint += DailyForecast_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelCurrDay;
        private System.Windows.Forms.ListBox listBoxModelHouses;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxAverage;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.CheckBox checkBoxSmooth;
        private System.Windows.Forms.Panel panelElectric;
        private System.Windows.Forms.Panel panelMains;
        private System.Windows.Forms.Panel panelOther;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelAverageDaily;
        private System.Windows.Forms.RadioButton radioButtonOne;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.ListBox listBoxGenerators;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.CheckBox checkBoxArrayTotal;
        private System.Windows.Forms.Label labelMissingData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.CheckBox checkBoxFactoyLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelConsume;
        private System.Windows.Forms.Label labelGenerate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelNet;
    }
}