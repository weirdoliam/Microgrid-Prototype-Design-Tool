﻿namespace WinFormsApp1
{
    partial class LoadComparison
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
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            labelSunrise = new System.Windows.Forms.Label();
            labelSunset = new System.Windows.Forms.Label();
            labelPanel = new System.Windows.Forms.Panel();
            checkBoxSmooth = new System.Windows.Forms.CheckBox();
            labelAverageDaily = new System.Windows.Forms.Label();
            listBoxGenerators = new System.Windows.Forms.ListBox();
            checkBoxArrayTotal = new System.Windows.Forms.CheckBox();
            labelMissingData = new System.Windows.Forms.Label();
            updateTimer = new System.Windows.Forms.Timer(components);
            label1 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            labelConsume = new System.Windows.Forms.Label();
            labelGenerate = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            labelNet = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            checkBoxDaylight = new System.Windows.Forms.CheckBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            checkBoxWindspeeds = new System.Windows.Forms.CheckBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            canvas.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // labelCurrDay
            // 
            labelCurrDay.AutoSize = true;
            labelCurrDay.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCurrDay.Location = new System.Drawing.Point(11, 19);
            labelCurrDay.Name = "labelCurrDay";
            labelCurrDay.Size = new System.Drawing.Size(70, 37);
            labelCurrDay.TabIndex = 1;
            labelCurrDay.Text = "date";
            // 
            // listBoxModelHouses
            // 
            listBoxModelHouses.BackColor = System.Drawing.SystemColors.Window;
            listBoxModelHouses.ForeColor = System.Drawing.Color.Red;
            listBoxModelHouses.FormattingEnabled = true;
            listBoxModelHouses.ItemHeight = 15;
            listBoxModelHouses.Location = new System.Drawing.Point(676, 42);
            listBoxModelHouses.Name = "listBoxModelHouses";
            listBoxModelHouses.Size = new System.Drawing.Size(357, 64);
            listBoxModelHouses.TabIndex = 2;
            listBoxModelHouses.SelectedIndexChanged += listBoxModelHouses_SelectedIndexChanged;
            // 
            // canvas
            // 
            canvas.AutoSize = true;
            canvas.BackColor = System.Drawing.SystemColors.ControlLight;
            canvas.Controls.Add(label11);
            canvas.Controls.Add(label12);
            canvas.Controls.Add(labelSunrise);
            canvas.Controls.Add(labelSunset);
            canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            canvas.Location = new System.Drawing.Point(53, 19);
            canvas.Name = "canvas";
            canvas.Size = new System.Drawing.Size(985, 367);
            canvas.TabIndex = 4;
            canvas.Paint += panel1_Paint;
            canvas.MouseClick += canvas_MouseClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(264, 9);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(51, 15);
            label11.TabIndex = 28;
            label11.Text = "Sunrise: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(623, 9);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(48, 15);
            label12.TabIndex = 29;
            label12.Text = "Sunset: ";
            // 
            // labelSunrise
            // 
            labelSunrise.AutoSize = true;
            labelSunrise.Location = new System.Drawing.Point(311, 9);
            labelSunrise.Name = "labelSunrise";
            labelSunrise.Size = new System.Drawing.Size(44, 15);
            labelSunrise.TabIndex = 24;
            labelSunrise.Text = "sunrise";
            // 
            // labelSunset
            // 
            labelSunset.AutoSize = true;
            labelSunset.Location = new System.Drawing.Point(672, 9);
            labelSunset.Name = "labelSunset";
            labelSunset.Size = new System.Drawing.Size(41, 15);
            labelSunset.TabIndex = 25;
            labelSunset.Text = "sunset";
            // 
            // labelPanel
            // 
            labelPanel.BackColor = System.Drawing.SystemColors.Control;
            labelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            labelPanel.Location = new System.Drawing.Point(3, 19);
            labelPanel.Name = "labelPanel";
            labelPanel.Size = new System.Drawing.Size(50, 367);
            labelPanel.TabIndex = 11;
            labelPanel.Paint += panel1_Paint_1;
            // 
            // checkBoxSmooth
            // 
            checkBoxSmooth.AutoSize = true;
            checkBoxSmooth.Location = new System.Drawing.Point(11, 204);
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
            labelAverageDaily.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelAverageDaily.Location = new System.Drawing.Point(589, 168);
            labelAverageDaily.Name = "labelAverageDaily";
            labelAverageDaily.Size = new System.Drawing.Size(68, 28);
            labelAverageDaily.TabIndex = 20;
            labelAverageDaily.Text = "0 kWh";
            // 
            // listBoxGenerators
            // 
            listBoxGenerators.BackColor = System.Drawing.SystemColors.Window;
            listBoxGenerators.ForeColor = System.Drawing.Color.DarkOliveGreen;
            listBoxGenerators.FormattingEnabled = true;
            listBoxGenerators.ItemHeight = 15;
            listBoxGenerators.Location = new System.Drawing.Point(317, 42);
            listBoxGenerators.Name = "listBoxGenerators";
            listBoxGenerators.Size = new System.Drawing.Size(353, 64);
            listBoxGenerators.TabIndex = 23;
            listBoxGenerators.SelectedIndexChanged += listBoxGenerators_SelectedIndexChanged;
            // 
            // checkBoxArrayTotal
            // 
            checkBoxArrayTotal.AutoSize = true;
            checkBoxArrayTotal.Location = new System.Drawing.Point(11, 62);
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
            // updateTimer
            // 
            updateTimer.Enabled = true;
            updateTimer.Interval = 1000;
            updateTimer.Tick += updateTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(317, 112);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(243, 28);
            label1.TabIndex = 31;
            label1.Text = "Total energy consumption:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(317, 140);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(223, 28);
            label13.TabIndex = 32;
            label13.Text = "Total energy generation:";
            // 
            // labelConsume
            // 
            labelConsume.AutoSize = true;
            labelConsume.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelConsume.Location = new System.Drawing.Point(589, 112);
            labelConsume.Name = "labelConsume";
            labelConsume.Size = new System.Drawing.Size(68, 28);
            labelConsume.TabIndex = 33;
            labelConsume.Text = "0 kWh";
            // 
            // labelGenerate
            // 
            labelGenerate.AutoSize = true;
            labelGenerate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelGenerate.Location = new System.Drawing.Point(589, 140);
            labelGenerate.Name = "labelGenerate";
            labelGenerate.Size = new System.Drawing.Size(68, 28);
            labelGenerate.TabIndex = 34;
            labelGenerate.Text = "0 kWh";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(766, 168);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(127, 28);
            label14.TabIndex = 35;
            label14.Text = "Net for date: ";
            // 
            // labelNet
            // 
            labelNet.AutoSize = true;
            labelNet.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelNet.ForeColor = System.Drawing.Color.Black;
            labelNet.Location = new System.Drawing.Point(899, 168);
            labelNet.Name = "labelNet";
            labelNet.Size = new System.Drawing.Size(68, 28);
            labelNet.TabIndex = 36;
            labelNet.Text = "0 kWh";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(317, 168);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(266, 28);
            label10.TabIndex = 19;
            label10.Text = "Average Daily Comsumption:";
            // 
            // checkBoxDaylight
            // 
            checkBoxDaylight.AutoSize = true;
            checkBoxDaylight.Location = new System.Drawing.Point(11, 87);
            checkBoxDaylight.Name = "checkBoxDaylight";
            checkBoxDaylight.Size = new System.Drawing.Size(104, 19);
            checkBoxDaylight.TabIndex = 37;
            checkBoxDaylight.Text = "Visual Daylight";
            checkBoxDaylight.UseVisualStyleBackColor = true;
            checkBoxDaylight.CheckedChanged += checkBoxDaylight_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(checkBoxWindspeeds);
            groupBox1.Controls.Add(labelCurrDay);
            groupBox1.Controls.Add(labelNet);
            groupBox1.Controls.Add(checkBoxDaylight);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(checkBoxSmooth);
            groupBox1.Controls.Add(labelGenerate);
            groupBox1.Controls.Add(checkBoxArrayTotal);
            groupBox1.Controls.Add(labelConsume);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(listBoxGenerators);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listBoxModelHouses);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(labelAverageDaily);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1041, 229);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Graph conrol and information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(676, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 21);
            label3.TabIndex = 40;
            label3.Text = "Consumer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(317, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 21);
            label2.TabIndex = 39;
            label2.Text = "Generator";
            // 
            // checkBoxWindspeeds
            // 
            checkBoxWindspeeds.AutoSize = true;
            checkBoxWindspeeds.Location = new System.Drawing.Point(11, 112);
            checkBoxWindspeeds.Name = "checkBoxWindspeeds";
            checkBoxWindspeeds.Size = new System.Drawing.Size(128, 19);
            checkBoxWindspeeds.TabIndex = 38;
            checkBoxWindspeeds.Text = "Visual Wind Speeds";
            checkBoxWindspeeds.UseVisualStyleBackColor = true;
            checkBoxWindspeeds.CheckedChanged += checkBoxWindspeeds_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(canvas);
            groupBox2.Controls.Add(labelPanel);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(0, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1041, 389);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // LoadComparison
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1041, 618);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelMissingData);
            Name = "LoadComparison";
            Text = " ";
            Resize += DailyForecast_Resize;
            canvas.ResumeLayout(false);
            canvas.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelConsume;
        private System.Windows.Forms.Label labelGenerate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelNet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxDaylight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxWindspeeds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}