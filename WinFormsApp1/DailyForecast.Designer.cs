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
            labelPanel = new System.Windows.Forms.Panel();
            checkBoxSmooth = new System.Windows.Forms.CheckBox();
            labelAverageDaily = new System.Windows.Forms.Label();
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
            label10 = new System.Windows.Forms.Label();
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
            canvas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            canvas.AutoSize = true;
            canvas.BackColor = System.Drawing.SystemColors.ControlLight;
            canvas.Location = new System.Drawing.Point(47, 190);
            canvas.Name = "canvas";
            canvas.Size = new System.Drawing.Size(881, 332);
            canvas.TabIndex = 4;
            canvas.Paint += panel1_Paint;
            canvas.MouseClick += canvas_MouseClick;
            // 
            // labelPanel
            // 
            labelPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelPanel.BackColor = System.Drawing.SystemColors.Control;
            labelPanel.Location = new System.Drawing.Point(8, 190);
            labelPanel.Name = "labelPanel";
            labelPanel.Size = new System.Drawing.Size(40, 332);
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
            // labelAverageDaily
            // 
            labelAverageDaily.AutoSize = true;
            labelAverageDaily.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelAverageDaily.Location = new System.Drawing.Point(131, 137);
            labelAverageDaily.Name = "labelAverageDaily";
            labelAverageDaily.Size = new System.Drawing.Size(63, 25);
            labelAverageDaily.TabIndex = 20;
            labelAverageDaily.Text = "0 kWh";
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
            checkBoxArrayTotal.Location = new System.Drawing.Point(8, 44);
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
            checkBoxFactoyLoad.Location = new System.Drawing.Point(8, 68);
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
            label1.Location = new System.Drawing.Point(337, 94);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(243, 28);
            label1.TabIndex = 31;
            label1.Text = "Total energy consumption:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(337, 137);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(223, 28);
            label13.TabIndex = 32;
            label13.Text = "Total energy generation:";
            // 
            // labelConsume
            // 
            labelConsume.AutoSize = true;
            labelConsume.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelConsume.Location = new System.Drawing.Point(596, 94);
            labelConsume.Name = "labelConsume";
            labelConsume.Size = new System.Drawing.Size(52, 28);
            labelConsume.TabIndex = 33;
            labelConsume.Text = "cons";
            // 
            // labelGenerate
            // 
            labelGenerate.AutoSize = true;
            labelGenerate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelGenerate.Location = new System.Drawing.Point(596, 137);
            labelGenerate.Name = "labelGenerate";
            labelGenerate.Size = new System.Drawing.Size(45, 28);
            labelGenerate.TabIndex = 34;
            labelGenerate.Text = "gen";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(670, 94);
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
            labelNet.Location = new System.Drawing.Point(790, 94);
            labelNet.Name = "labelNet";
            labelNet.Size = new System.Drawing.Size(40, 28);
            labelNet.TabIndex = 36;
            labelNet.Text = "net";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(8, 94);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(323, 28);
            label10.TabIndex = 19;
            label10.Text = "Average Daily Comsumption (kWh):";
            // 
            // DailyForecast
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(932, 526);
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
            Controls.Add(labelAverageDaily);
            Controls.Add(label10);
            Controls.Add(checkBoxSmooth);
            Controls.Add(labelPanel);
            Controls.Add(canvas);
            Controls.Add(listBoxModelHouses);
            Controls.Add(labelCurrDay);
            Name = "DailyForecast";
            Text = "Daily Analysis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelCurrDay;
        private System.Windows.Forms.ListBox listBoxModelHouses;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.CheckBox checkBoxSmooth;
        private System.Windows.Forms.Label labelAverageDaily;
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
        private System.Windows.Forms.Label label10;
    }
}