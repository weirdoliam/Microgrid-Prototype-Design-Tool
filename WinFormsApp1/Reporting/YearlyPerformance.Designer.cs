namespace WinFormsApp1.Reporting
{
    partial class YearlyPerformance
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
            buttonEnergyBalance = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label14 = new System.Windows.Forms.Label();
            labelEffCost = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            labelBuyBack = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            labelPayback = new System.Windows.Forms.Label();
            labelSetupCost = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            labelSaved = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            labelGridCost = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            labelInternalNet = new System.Windows.Forms.Label();
            labelTotalStorage = new System.Windows.Forms.Label();
            labelTotalConsumption = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            labelRenew = new System.Windows.Forms.Label();
            labelDirty = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            labelCo2 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            labelSolarPercent = new System.Windows.Forms.Label();
            labelWindPercent = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            mainPlot = new OxyPlot.WindowsForms.PlotView();
            rb1 = new System.Windows.Forms.RadioButton();
            rb2 = new System.Windows.Forms.RadioButton();
            rb3 = new System.Windows.Forms.RadioButton();
            rb4 = new System.Windows.Forms.RadioButton();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonEnergyBalance
            // 
            buttonEnergyBalance.Location = new System.Drawing.Point(6, 214);
            buttonEnergyBalance.Name = "buttonEnergyBalance";
            buttonEnergyBalance.Size = new System.Drawing.Size(111, 23);
            buttonEnergyBalance.TabIndex = 0;
            buttonEnergyBalance.Text = "Energy Balance";
            buttonEnergyBalance.UseVisualStyleBackColor = true;
            buttonEnergyBalance.Click += buttonEnergyBalance_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(buttonEnergyBalance);
            groupBox2.Controls.Add(labelEffCost);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(labelBuyBack);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(labelPayback);
            groupBox2.Controls.Add(labelSetupCost);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(labelSaved);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(labelGridCost);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(labelInternalNet);
            groupBox2.Controls.Add(labelTotalStorage);
            groupBox2.Controls.Add(labelTotalConsumption);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(labelRenew);
            groupBox2.Controls.Add(labelDirty);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(labelCo2);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(labelSolarPercent);
            groupBox2.Controls.Add(labelWindPercent);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new System.Drawing.Point(12, 608);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1616, 241);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label14.Location = new System.Drawing.Point(752, 175);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(123, 23);
            label14.TabIndex = 35;
            label14.Text = "Actual Cost: ";
            // 
            // labelEffCost
            // 
            labelEffCost.AutoSize = true;
            labelEffCost.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEffCost.Location = new System.Drawing.Point(975, 97);
            labelEffCost.Name = "labelEffCost";
            labelEffCost.Size = new System.Drawing.Size(60, 23);
            labelEffCost.TabIndex = 34;
            labelEffCost.Text = "$0.00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label13.Location = new System.Drawing.Point(752, 97);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(145, 23);
            label13.TabIndex = 33;
            label13.Text = "Effective Cost: ";
            // 
            // labelBuyBack
            // 
            labelBuyBack.AutoSize = true;
            labelBuyBack.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelBuyBack.Location = new System.Drawing.Point(1407, 138);
            labelBuyBack.Name = "labelBuyBack";
            labelBuyBack.Size = new System.Drawing.Size(60, 23);
            labelBuyBack.TabIndex = 32;
            labelBuyBack.Text = "$0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label12.Location = new System.Drawing.Point(1256, 136);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(141, 23);
            label12.TabIndex = 31;
            label12.Text = "Grid Buyback: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(1306, 198);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(155, 14);
            label6.TabIndex = 30;
            label6.Text = "*Based Average Daily Savings";
            // 
            // pictureBox5
            // 
            pictureBox5.ErrorImage = Properties.Resources.panel;
            pictureBox5.Image = Properties.Resources.charge;
            pictureBox5.InitialImage = Properties.Resources.panel;
            pictureBox5.Location = new System.Drawing.Point(38, 158);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(50, 50);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            // 
            // labelPayback
            // 
            labelPayback.AutoSize = true;
            labelPayback.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPayback.Location = new System.Drawing.Point(1407, 176);
            labelPayback.Name = "labelPayback";
            labelPayback.Size = new System.Drawing.Size(78, 23);
            labelPayback.TabIndex = 28;
            labelPayback.Text = "0 Years";
            // 
            // labelSetupCost
            // 
            labelSetupCost.AutoSize = true;
            labelSetupCost.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSetupCost.Location = new System.Drawing.Point(1407, 62);
            labelSetupCost.Name = "labelSetupCost";
            labelSetupCost.Size = new System.Drawing.Size(60, 23);
            labelSetupCost.TabIndex = 27;
            labelSetupCost.Text = "$0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label11.Location = new System.Drawing.Point(1256, 175);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(148, 23);
            label11.TabIndex = 26;
            label11.Text = "Payoff period*: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label10.Location = new System.Drawing.Point(1256, 58);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(114, 23);
            label10.TabIndex = 25;
            label10.Text = "Setup Cost:";
            // 
            // labelSaved
            // 
            labelSaved.AutoSize = true;
            labelSaved.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSaved.Location = new System.Drawing.Point(1407, 100);
            labelSaved.Name = "labelSaved";
            labelSaved.Size = new System.Drawing.Size(60, 23);
            labelSaved.TabIndex = 24;
            labelSaved.Text = "$0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label9.Location = new System.Drawing.Point(1256, 97);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(137, 23);
            label9.TabIndex = 23;
            label9.Text = "Year Savings: ";
            // 
            // labelGridCost
            // 
            labelGridCost.AutoSize = true;
            labelGridCost.BackColor = System.Drawing.Color.Transparent;
            labelGridCost.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelGridCost.Location = new System.Drawing.Point(975, 175);
            labelGridCost.Name = "labelGridCost";
            labelGridCost.Size = new System.Drawing.Size(60, 23);
            labelGridCost.TabIndex = 22;
            labelGridCost.Text = "$0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            label8.Location = new System.Drawing.Point(1256, 19);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(163, 27);
            label8.TabIndex = 20;
            label8.Text = "Cost Analysis:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label7.Location = new System.Drawing.Point(752, 136);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(123, 23);
            label7.TabIndex = 19;
            label7.Text = "Internal Net: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label5.Location = new System.Drawing.Point(752, 58);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(203, 23);
            label5.TabIndex = 17;
            label5.Text = "Overall Consumption: ";
            // 
            // labelInternalNet
            // 
            labelInternalNet.AutoSize = true;
            labelInternalNet.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelInternalNet.Location = new System.Drawing.Point(975, 136);
            labelInternalNet.Name = "labelInternalNet";
            labelInternalNet.Size = new System.Drawing.Size(60, 23);
            labelInternalNet.TabIndex = 16;
            labelInternalNet.Text = "0kWh";
            // 
            // labelTotalStorage
            // 
            labelTotalStorage.AutoSize = true;
            labelTotalStorage.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTotalStorage.Location = new System.Drawing.Point(94, 170);
            labelTotalStorage.Name = "labelTotalStorage";
            labelTotalStorage.Size = new System.Drawing.Size(40, 23);
            labelTotalStorage.TabIndex = 15;
            labelTotalStorage.Text = "0W";
            // 
            // labelTotalConsumption
            // 
            labelTotalConsumption.AutoSize = true;
            labelTotalConsumption.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTotalConsumption.Location = new System.Drawing.Point(975, 58);
            labelTotalConsumption.Name = "labelTotalConsumption";
            labelTotalConsumption.Size = new System.Drawing.Size(60, 23);
            labelTotalConsumption.TabIndex = 13;
            labelTotalConsumption.Text = "0kWh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            label4.Location = new System.Drawing.Point(752, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 27);
            label4.TabIndex = 12;
            label4.Text = "Totals:";
            // 
            // labelRenew
            // 
            labelRenew.AutoSize = true;
            labelRenew.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelRenew.Location = new System.Drawing.Point(413, 55);
            labelRenew.Name = "labelRenew";
            labelRenew.Size = new System.Drawing.Size(86, 32);
            labelRenew.TabIndex = 11;
            labelRenew.Text = "0kWh";
            // 
            // labelDirty
            // 
            labelDirty.AutoSize = true;
            labelDirty.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDirty.Location = new System.Drawing.Point(51, 55);
            labelDirty.Name = "labelDirty";
            labelDirty.Size = new System.Drawing.Size(86, 32);
            labelDirty.TabIndex = 10;
            labelDirty.Text = "0kWh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            label3.Location = new System.Drawing.Point(35, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 27);
            label3.TabIndex = 9;
            label3.Text = "From Grid: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            label15.Location = new System.Drawing.Point(387, 19);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(139, 27);
            label15.TabIndex = 8;
            label15.Text = "Renewable:";
            // 
            // labelCo2
            // 
            labelCo2.AutoSize = true;
            labelCo2.BackColor = System.Drawing.Color.Transparent;
            labelCo2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCo2.Location = new System.Drawing.Point(94, 112);
            labelCo2.Name = "labelCo2";
            labelCo2.Size = new System.Drawing.Size(63, 23);
            labelCo2.TabIndex = 7;
            labelCo2.Text = "0kg/w";
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = Properties.Resources.panel;
            pictureBox3.Image = Properties.Resources.co2;
            pictureBox3.InitialImage = Properties.Resources.panel;
            pictureBox3.Location = new System.Drawing.Point(38, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(50, 50);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // labelSolarPercent
            // 
            labelSolarPercent.AutoSize = true;
            labelSolarPercent.BackColor = System.Drawing.Color.Transparent;
            labelSolarPercent.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSolarPercent.Location = new System.Drawing.Point(465, 170);
            labelSolarPercent.Name = "labelSolarPercent";
            labelSolarPercent.Size = new System.Drawing.Size(61, 23);
            labelSolarPercent.TabIndex = 5;
            labelSolarPercent.Text = "100%";
            // 
            // labelWindPercent
            // 
            labelWindPercent.AutoSize = true;
            labelWindPercent.BackColor = System.Drawing.Color.Transparent;
            labelWindPercent.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelWindPercent.Location = new System.Drawing.Point(465, 112);
            labelWindPercent.Name = "labelWindPercent";
            labelWindPercent.Size = new System.Drawing.Size(61, 23);
            labelWindPercent.TabIndex = 4;
            labelWindPercent.Text = "100%";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.panel;
            pictureBox2.Image = Properties.Resources.turb;
            pictureBox2.InitialImage = Properties.Resources.panel;
            pictureBox2.Location = new System.Drawing.Point(387, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(50, 50);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.panel;
            pictureBox1.Image = Properties.Resources.panel;
            pictureBox1.InitialImage = Properties.Resources.panel;
            pictureBox1.Location = new System.Drawing.Point(387, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(50, 50);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // mainPlot
            // 
            mainPlot.BackColor = System.Drawing.SystemColors.ControlLight;
            mainPlot.Location = new System.Drawing.Point(12, 12);
            mainPlot.Name = "mainPlot";
            mainPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            mainPlot.Size = new System.Drawing.Size(1616, 546);
            mainPlot.TabIndex = 6;
            mainPlot.Text = "plotView1";
            mainPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            mainPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            mainPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new System.Drawing.Point(12, 574);
            rb1.Name = "rb1";
            rb1.Size = new System.Drawing.Size(138, 19);
            rb1.TabIndex = 7;
            rb1.TabStop = true;
            rb1.Text = "Overall Consumption";
            rb1.UseVisualStyleBackColor = true;
            rb1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new System.Drawing.Point(196, 574);
            rb2.Name = "rb2";
            rb2.Size = new System.Drawing.Size(123, 19);
            rb2.TabIndex = 8;
            rb2.TabStop = true;
            rb2.Text = "Overall Generation";
            rb2.UseVisualStyleBackColor = true;
            rb2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new System.Drawing.Point(365, 574);
            rb3.Name = "rb3";
            rb3.Size = new System.Drawing.Size(123, 19);
            rb3.TabIndex = 9;
            rb3.TabStop = true;
            rb3.Text = "Overall Grid Needs";
            rb3.UseVisualStyleBackColor = true;
            rb3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new System.Drawing.Point(534, 574);
            rb4.Name = "rb4";
            rb4.Size = new System.Drawing.Size(97, 19);
            rb4.TabIndex = 10;
            rb4.TabStop = true;
            rb4.Text = "Battery Usage";
            rb4.UseVisualStyleBackColor = true;
            rb4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // YearlyPerformance
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1640, 861);
            Controls.Add(rb4);
            Controls.Add(rb3);
            Controls.Add(rb2);
            Controls.Add(rb1);
            Controls.Add(mainPlot);
            Controls.Add(groupBox2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "YearlyPerformance";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "YearlyPerformance";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonEnergyBalance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelEffCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelBuyBack;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelPayback;
        private System.Windows.Forms.Label labelSetupCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelSaved;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelGridCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelInternalNet;
        private System.Windows.Forms.Label labelTotalStorage;
        private System.Windows.Forms.Label labelTotalConsumption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRenew;
        private System.Windows.Forms.Label labelDirty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelCo2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelSolarPercent;
        private System.Windows.Forms.Label labelWindPercent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private OxyPlot.WindowsForms.PlotView mainPlot;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
    }
}