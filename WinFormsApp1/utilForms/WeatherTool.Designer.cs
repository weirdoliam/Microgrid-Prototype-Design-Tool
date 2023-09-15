namespace WinFormsApp1
{
    partial class WeatherTool
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
            panelClouds = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            labelCurrSpeed = new System.Windows.Forms.Label();
            labelNewSpeed = new System.Windows.Forms.Label();
            labelDate = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            labelCurrYVal = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            labelDist = new System.Windows.Forms.Label();
            panelMainCanvas = new System.Windows.Forms.Panel();
            labelxinc = new System.Windows.Forms.Label();
            labelHeight = new System.Windows.Forms.Label();
            labelWidth = new System.Windows.Forms.Label();
            labelSector = new System.Windows.Forms.Label();
            labelY = new System.Windows.Forms.Label();
            labelX = new System.Windows.Forms.Label();
            timerMain = new System.Windows.Forms.Timer(components);
            checkDev = new System.Windows.Forms.CheckBox();
            label6 = new System.Windows.Forms.Label();
            panelClouds.SuspendLayout();
            panelMainCanvas.SuspendLayout();
            SuspendLayout();
            // 
            // panelClouds
            // 
            panelClouds.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panelClouds.Controls.Add(label6);
            panelClouds.Controls.Add(label5);
            panelClouds.Controls.Add(label4);
            panelClouds.Controls.Add(labelCurrSpeed);
            panelClouds.Controls.Add(labelNewSpeed);
            panelClouds.Controls.Add(labelDate);
            panelClouds.Controls.Add(label3);
            panelClouds.Controls.Add(label2);
            panelClouds.Dock = System.Windows.Forms.DockStyle.Top;
            panelClouds.Location = new System.Drawing.Point(0, 0);
            panelClouds.Name = "panelClouds";
            panelClouds.Size = new System.Drawing.Size(704, 77);
            panelClouds.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(409, 54);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(121, 15);
            label5.TabIndex = 8;
            label5.Text = "with new windspeed: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(409, 31);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(114, 15);
            label4.TabIndex = 7;
            label4.Text = "Replace windspeed: ";
            // 
            // labelCurrSpeed
            // 
            labelCurrSpeed.AutoSize = true;
            labelCurrSpeed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            labelCurrSpeed.Location = new System.Drawing.Point(529, 31);
            labelCurrSpeed.Name = "labelCurrSpeed";
            labelCurrSpeed.Size = new System.Drawing.Size(13, 15);
            labelCurrSpeed.TabIndex = 6;
            labelCurrSpeed.Text = "0";
            // 
            // labelNewSpeed
            // 
            labelNewSpeed.AutoSize = true;
            labelNewSpeed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            labelNewSpeed.Location = new System.Drawing.Point(529, 54);
            labelNewSpeed.Name = "labelNewSpeed";
            labelNewSpeed.Size = new System.Drawing.Size(13, 15);
            labelNewSpeed.TabIndex = 4;
            labelNewSpeed.Text = "0";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDate.Location = new System.Drawing.Point(48, 48);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(34, 21);
            labelDate.TabIndex = 2;
            labelDate.Text = "1/1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(5, 48);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 21);
            label3.TabIndex = 1;
            label3.Text = "Date: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(246, 37);
            label2.TabIndex = 0;
            label2.Text = "Windspeed Editor";
            // 
            // labelCurrYVal
            // 
            labelCurrYVal.AutoSize = true;
            labelCurrYVal.BackColor = System.Drawing.SystemColors.Control;
            labelCurrYVal.Location = new System.Drawing.Point(510, 513);
            labelCurrYVal.Name = "labelCurrYVal";
            labelCurrYVal.Size = new System.Drawing.Size(52, 15);
            labelCurrYVal.TabIndex = 3;
            labelCurrYVal.Text = "CurrYVal";
            labelCurrYVal.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(12, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Wind Speed";
            // 
            // labelDist
            // 
            labelDist.AutoSize = true;
            labelDist.BackColor = System.Drawing.SystemColors.Control;
            labelDist.Location = new System.Drawing.Point(208, 513);
            labelDist.Name = "labelDist";
            labelDist.Size = new System.Drawing.Size(26, 15);
            labelDist.TabIndex = 7;
            labelDist.Text = "dist";
            labelDist.Visible = false;
            // 
            // panelMainCanvas
            // 
            panelMainCanvas.Controls.Add(label1);
            panelMainCanvas.Dock = System.Windows.Forms.DockStyle.Top;
            panelMainCanvas.Location = new System.Drawing.Point(0, 77);
            panelMainCanvas.Name = "panelMainCanvas";
            panelMainCanvas.Size = new System.Drawing.Size(704, 424);
            panelMainCanvas.TabIndex = 1;
            panelMainCanvas.MouseDown += panelMainCanvas_MouseDown;
            panelMainCanvas.MouseLeave += panelMainCanvas_MouseLeave;
            panelMainCanvas.MouseMove += panelMainCanvas_MouseMove;
            panelMainCanvas.MouseUp += panelMainCanvas_MouseUp;
            // 
            // labelxinc
            // 
            labelxinc.AutoSize = true;
            labelxinc.BackColor = System.Drawing.SystemColors.Control;
            labelxinc.Location = new System.Drawing.Point(260, 513);
            labelxinc.Name = "labelxinc";
            labelxinc.Size = new System.Drawing.Size(79, 15);
            labelxinc.TabIndex = 10;
            labelxinc.Text = "interval (xInc)";
            labelxinc.Visible = false;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.BackColor = System.Drawing.SystemColors.Control;
            labelHeight.Location = new System.Drawing.Point(588, 513);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new System.Drawing.Size(41, 15);
            labelHeight.TabIndex = 9;
            labelHeight.Text = "height";
            labelHeight.Visible = false;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.BackColor = System.Drawing.SystemColors.Control;
            labelWidth.Location = new System.Drawing.Point(655, 513);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new System.Drawing.Size(37, 15);
            labelWidth.TabIndex = 8;
            labelWidth.Text = "width";
            labelWidth.Visible = false;
            // 
            // labelSector
            // 
            labelSector.AutoSize = true;
            labelSector.BackColor = System.Drawing.SystemColors.Control;
            labelSector.Location = new System.Drawing.Point(445, 513);
            labelSector.Name = "labelSector";
            labelSector.Size = new System.Drawing.Size(39, 15);
            labelSector.TabIndex = 5;
            labelSector.Text = "sector";
            labelSector.Visible = false;
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.BackColor = System.Drawing.SystemColors.Control;
            labelY.Location = new System.Drawing.Point(405, 513);
            labelY.Name = "labelY";
            labelY.Size = new System.Drawing.Size(14, 15);
            labelY.TabIndex = 2;
            labelY.Text = "Y";
            labelY.Visible = false;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.BackColor = System.Drawing.SystemColors.Control;
            labelX.Location = new System.Drawing.Point(365, 513);
            labelX.Name = "labelX";
            labelX.Size = new System.Drawing.Size(14, 15);
            labelX.TabIndex = 1;
            labelX.Text = "X";
            labelX.Visible = false;
            // 
            // timerMain
            // 
            timerMain.Interval = 50;
            timerMain.Tick += timerMain_Tick;
            // 
            // checkDev
            // 
            checkDev.AutoSize = true;
            checkDev.Location = new System.Drawing.Point(13, 512);
            checkDev.Name = "checkDev";
            checkDev.Size = new System.Drawing.Size(180, 19);
            checkDev.TabIndex = 2;
            checkDev.Text = "dev mode (display extra info)";
            checkDev.UseVisualStyleBackColor = true;
            checkDev.CheckedChanged += checkDev_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(397, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(295, 15);
            label6.TabIndex = 9;
            label6.Text = "Click and drag to draw windspeed through current day";
            // 
            // WeatherTool
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(704, 538);
            Controls.Add(labelSector);
            Controls.Add(labelxinc);
            Controls.Add(labelY);
            Controls.Add(checkDev);
            Controls.Add(labelX);
            Controls.Add(labelCurrYVal);
            Controls.Add(labelDist);
            Controls.Add(labelHeight);
            Controls.Add(panelMainCanvas);
            Controls.Add(panelClouds);
            Controls.Add(labelWidth);
            Name = "WeatherTool";
            Text = "WeatherTool";
            Resize += WeatherTool_Resize;
            panelClouds.ResumeLayout(false);
            panelClouds.PerformLayout();
            panelMainCanvas.ResumeLayout(false);
            panelMainCanvas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelClouds;
        private System.Windows.Forms.Panel panelMainCanvas;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelCurrYVal;
        private System.Windows.Forms.Label labelSector;
        private System.Windows.Forms.Label labelNewSpeed;
        private System.Windows.Forms.Label labelCurrSpeed;
        private System.Windows.Forms.Label labelDist;
        private System.Windows.Forms.CheckBox checkDev;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelxinc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}