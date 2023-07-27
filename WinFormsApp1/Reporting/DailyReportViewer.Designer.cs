namespace WinFormsApp1
{
    partial class DailyReportViewer
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
            mainCanvas = new System.Windows.Forms.Panel();
            checkedListBoxData = new System.Windows.Forms.CheckedListBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            labelDate = new System.Windows.Forms.Label();
            panelX = new System.Windows.Forms.Panel();
            panelY = new System.Windows.Forms.Panel();
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
            label2 = new System.Windows.Forms.Label();
            labelCo2 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            labelSolarPercent = new System.Windows.Forms.Label();
            labelWindPercent = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            richTextBoxResponce = new System.Windows.Forms.RichTextBox();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            toolTipCapacity = new System.Windows.Forms.ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainCanvas
            // 
            mainCanvas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            mainCanvas.BackColor = System.Drawing.SystemColors.Window;
            mainCanvas.Location = new System.Drawing.Point(168, 19);
            mainCanvas.Name = "mainCanvas";
            mainCanvas.Size = new System.Drawing.Size(1107, 367);
            mainCanvas.TabIndex = 0;
            mainCanvas.Paint += mainCanvas_Paint;
            mainCanvas.Resize += mainCanvas_Resize;
            // 
            // checkedListBoxData
            // 
            checkedListBoxData.FormattingEnabled = true;
            checkedListBoxData.Location = new System.Drawing.Point(3, 84);
            checkedListBoxData.Name = "checkedListBoxData";
            checkedListBoxData.Size = new System.Drawing.Size(108, 328);
            checkedListBoxData.TabIndex = 1;
            checkedListBoxData.Click += checkedListBoxData_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelDate);
            groupBox1.Controls.Add(mainCanvas);
            groupBox1.Controls.Add(panelX);
            groupBox1.Controls.Add(panelY);
            groupBox1.Controls.Add(checkedListBoxData);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1278, 412);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Graphing";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDate.Location = new System.Drawing.Point(0, 19);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(62, 41);
            labelDate.TabIndex = 4;
            labelDate.Text = "1/1";
            // 
            // panelX
            // 
            panelX.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelX.BackColor = System.Drawing.SystemColors.Control;
            panelX.Location = new System.Drawing.Point(111, 385);
            panelX.Name = "panelX";
            panelX.Size = new System.Drawing.Size(1164, 27);
            panelX.TabIndex = 3;
            panelX.Paint += panelX_Paint;
            // 
            // panelY
            // 
            panelY.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panelY.BackColor = System.Drawing.SystemColors.Control;
            panelY.Location = new System.Drawing.Point(111, 19);
            panelY.Name = "panelY";
            panelY.Size = new System.Drawing.Size(59, 367);
            panelY.TabIndex = 2;
            panelY.Paint += panelY_Paint;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(label14);
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
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(labelCo2);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(labelSolarPercent);
            groupBox2.Controls.Add(labelWindPercent);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(richTextBoxResponce);
            groupBox2.Location = new System.Drawing.Point(3, 418);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1275, 342);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label14.Location = new System.Drawing.Point(603, 175);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(123, 23);
            label14.TabIndex = 35;
            label14.Text = "Actual Cost: ";
            // 
            // labelEffCost
            // 
            labelEffCost.AutoSize = true;
            labelEffCost.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEffCost.Location = new System.Drawing.Point(826, 97);
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
            label13.Location = new System.Drawing.Point(603, 97);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(145, 23);
            label13.TabIndex = 33;
            label13.Text = "Effective Cost: ";
            // 
            // labelBuyBack
            // 
            labelBuyBack.AutoSize = true;
            labelBuyBack.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelBuyBack.Location = new System.Drawing.Point(1125, 138);
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
            label12.Location = new System.Drawing.Point(974, 136);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(141, 23);
            label12.TabIndex = 31;
            label12.Text = "Grid Buyback: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(1024, 198);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(86, 14);
            label6.TabIndex = 30;
            label6.Text = "*Based off today";
            // 
            // pictureBox5
            // 
            pictureBox5.ErrorImage = Properties.Resources.panel;
            pictureBox5.Image = Properties.Resources.charge;
            pictureBox5.InitialImage = Properties.Resources.panel;
            pictureBox5.Location = new System.Drawing.Point(9, 158);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(50, 50);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            toolTipCapacity.SetToolTip(pictureBox5, "Total Grid Capacity");
            // 
            // labelPayback
            // 
            labelPayback.AutoSize = true;
            labelPayback.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPayback.Location = new System.Drawing.Point(1125, 176);
            labelPayback.Name = "labelPayback";
            labelPayback.Size = new System.Drawing.Size(78, 23);
            labelPayback.TabIndex = 28;
            labelPayback.Text = "0 Years";
            // 
            // labelSetupCost
            // 
            labelSetupCost.AutoSize = true;
            labelSetupCost.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSetupCost.Location = new System.Drawing.Point(1125, 62);
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
            label11.Location = new System.Drawing.Point(974, 175);
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
            label10.Location = new System.Drawing.Point(974, 58);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(114, 23);
            label10.TabIndex = 25;
            label10.Text = "Setup Cost:";
            // 
            // labelSaved
            // 
            labelSaved.AutoSize = true;
            labelSaved.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSaved.Location = new System.Drawing.Point(1125, 100);
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
            label9.Location = new System.Drawing.Point(974, 97);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(136, 23);
            label9.TabIndex = 23;
            label9.Text = "Saved Today: ";
            // 
            // labelGridCost
            // 
            labelGridCost.AutoSize = true;
            labelGridCost.BackColor = System.Drawing.Color.Transparent;
            labelGridCost.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelGridCost.Location = new System.Drawing.Point(826, 175);
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
            label8.Location = new System.Drawing.Point(974, 19);
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
            label7.Location = new System.Drawing.Point(603, 136);
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
            label5.Location = new System.Drawing.Point(603, 58);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(203, 23);
            label5.TabIndex = 17;
            label5.Text = "Overall Consumption: ";
            // 
            // labelInternalNet
            // 
            labelInternalNet.AutoSize = true;
            labelInternalNet.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelInternalNet.Location = new System.Drawing.Point(826, 136);
            labelInternalNet.Name = "labelInternalNet";
            labelInternalNet.Size = new System.Drawing.Size(60, 23);
            labelInternalNet.TabIndex = 16;
            labelInternalNet.Text = "0kWh";
            // 
            // labelTotalStorage
            // 
            labelTotalStorage.AutoSize = true;
            labelTotalStorage.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTotalStorage.Location = new System.Drawing.Point(65, 170);
            labelTotalStorage.Name = "labelTotalStorage";
            labelTotalStorage.Size = new System.Drawing.Size(40, 23);
            labelTotalStorage.TabIndex = 15;
            labelTotalStorage.Text = "0W";
            // 
            // labelTotalConsumption
            // 
            labelTotalConsumption.AutoSize = true;
            labelTotalConsumption.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTotalConsumption.Location = new System.Drawing.Point(826, 58);
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
            label4.Location = new System.Drawing.Point(603, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 27);
            label4.TabIndex = 12;
            label4.Text = "Totals:";
            // 
            // labelRenew
            // 
            labelRenew.AutoSize = true;
            labelRenew.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelRenew.Location = new System.Drawing.Point(309, 55);
            labelRenew.Name = "labelRenew";
            labelRenew.Size = new System.Drawing.Size(86, 32);
            labelRenew.TabIndex = 11;
            labelRenew.Text = "0kWh";
            // 
            // labelDirty
            // 
            labelDirty.AutoSize = true;
            labelDirty.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDirty.Location = new System.Drawing.Point(22, 55);
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
            label3.Location = new System.Drawing.Point(6, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 27);
            label3.TabIndex = 9;
            label3.Text = "From Grid: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            label2.Location = new System.Drawing.Point(283, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(139, 27);
            label2.TabIndex = 8;
            label2.Text = "Renewable:";
            // 
            // labelCo2
            // 
            labelCo2.AutoSize = true;
            labelCo2.BackColor = System.Drawing.Color.Transparent;
            labelCo2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCo2.Location = new System.Drawing.Point(65, 112);
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
            pictureBox3.Location = new System.Drawing.Point(9, 97);
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
            labelSolarPercent.Location = new System.Drawing.Point(361, 170);
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
            labelWindPercent.Location = new System.Drawing.Point(361, 112);
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
            pictureBox2.Location = new System.Drawing.Point(283, 97);
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
            pictureBox1.Location = new System.Drawing.Point(283, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(50, 50);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 263);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 15);
            label1.TabIndex = 1;
            label1.Text = "GPT-Turbo-3.5 Report:";
            // 
            // richTextBoxResponce
            // 
            richTextBoxResponce.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBoxResponce.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            richTextBoxResponce.Location = new System.Drawing.Point(6, 281);
            richTextBoxResponce.Name = "richTextBoxResponce";
            richTextBoxResponce.Size = new System.Drawing.Size(1263, 50);
            richTextBoxResponce.TabIndex = 0;
            richTextBoxResponce.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DailyReportViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1278, 761);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DailyReportViewer";
            Text = "Single Day Report";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainCanvas;
        private System.Windows.Forms.CheckedListBox checkedListBoxData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelX;
        private System.Windows.Forms.Panel panelY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxResponce;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSolarPercent;
        private System.Windows.Forms.Label labelWindPercent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCo2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRenew;
        private System.Windows.Forms.Label labelDirty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInternalNet;
        private System.Windows.Forms.Label labelTotalStorage;
        private System.Windows.Forms.Label labelTotalConsumption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelGridCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelSaved;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelPayback;
        private System.Windows.Forms.Label labelSetupCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelBuyBack;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelEffCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolTip toolTipCapacity;
        private System.Windows.Forms.Label labelDate;
    }
}