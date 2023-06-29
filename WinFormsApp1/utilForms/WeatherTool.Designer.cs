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
            this.components = new System.ComponentModel.Container();
            this.panelClouds = new System.Windows.Forms.Panel();
            this.labelDist = new System.Windows.Forms.Label();
            this.panelMainCanvas = new System.Windows.Forms.Panel();
            this.labelxinc = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelCurrSpeed = new System.Windows.Forms.Label();
            this.labelSector = new System.Windows.Forms.Label();
            this.labelNewSpeed = new System.Windows.Forms.Label();
            this.labelCurrYVal = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.checkDev = new System.Windows.Forms.CheckBox();
            this.panelMainCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClouds
            // 
            this.panelClouds.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClouds.Location = new System.Drawing.Point(0, 0);
            this.panelClouds.Name = "panelClouds";
            this.panelClouds.Size = new System.Drawing.Size(704, 77);
            this.panelClouds.TabIndex = 0;
            // 
            // labelDist
            // 
            this.labelDist.AutoSize = true;
            this.labelDist.BackColor = System.Drawing.SystemColors.Control;
            this.labelDist.Location = new System.Drawing.Point(374, 48);
            this.labelDist.Name = "labelDist";
            this.labelDist.Size = new System.Drawing.Size(26, 15);
            this.labelDist.TabIndex = 7;
            this.labelDist.Text = "dist";
            this.labelDist.Visible = false;
            // 
            // panelMainCanvas
            // 
            this.panelMainCanvas.Controls.Add(this.labelxinc);
            this.panelMainCanvas.Controls.Add(this.labelHeight);
            this.panelMainCanvas.Controls.Add(this.labelDist);
            this.panelMainCanvas.Controls.Add(this.labelWidth);
            this.panelMainCanvas.Controls.Add(this.labelCurrSpeed);
            this.panelMainCanvas.Controls.Add(this.labelSector);
            this.panelMainCanvas.Controls.Add(this.labelNewSpeed);
            this.panelMainCanvas.Controls.Add(this.labelCurrYVal);
            this.panelMainCanvas.Controls.Add(this.labelY);
            this.panelMainCanvas.Controls.Add(this.labelX);
            this.panelMainCanvas.Controls.Add(this.label1);
            this.panelMainCanvas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainCanvas.Location = new System.Drawing.Point(0, 77);
            this.panelMainCanvas.Name = "panelMainCanvas";
            this.panelMainCanvas.Size = new System.Drawing.Size(704, 337);
            this.panelMainCanvas.TabIndex = 1;
            this.panelMainCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMainCanvas_MouseDown);
            this.panelMainCanvas.MouseLeave += new System.EventHandler(this.panelMainCanvas_MouseLeave);
            this.panelMainCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMainCanvas_MouseMove);
            this.panelMainCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMainCanvas_MouseUp);
            // 
            // labelxinc
            // 
            this.labelxinc.AutoSize = true;
            this.labelxinc.BackColor = System.Drawing.SystemColors.Control;
            this.labelxinc.Location = new System.Drawing.Point(374, 63);
            this.labelxinc.Name = "labelxinc";
            this.labelxinc.Size = new System.Drawing.Size(79, 15);
            this.labelxinc.TabIndex = 10;
            this.labelxinc.Text = "interval (xInc)";
            this.labelxinc.Visible = false;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.BackColor = System.Drawing.SystemColors.Control;
            this.labelHeight.Location = new System.Drawing.Point(630, 3);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(41, 15);
            this.labelHeight.TabIndex = 9;
            this.labelHeight.Text = "height";
            this.labelHeight.Visible = false;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.BackColor = System.Drawing.SystemColors.Control;
            this.labelWidth.Location = new System.Drawing.Point(587, 3);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(37, 15);
            this.labelWidth.TabIndex = 8;
            this.labelWidth.Text = "width";
            this.labelWidth.Visible = false;
            // 
            // labelCurrSpeed
            // 
            this.labelCurrSpeed.AutoSize = true;
            this.labelCurrSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.labelCurrSpeed.Location = new System.Drawing.Point(374, 18);
            this.labelCurrSpeed.Name = "labelCurrSpeed";
            this.labelCurrSpeed.Size = new System.Drawing.Size(62, 15);
            this.labelCurrSpeed.TabIndex = 6;
            this.labelCurrSpeed.Text = "CurrSpeed";
            this.labelCurrSpeed.Visible = false;
            // 
            // labelSector
            // 
            this.labelSector.AutoSize = true;
            this.labelSector.BackColor = System.Drawing.SystemColors.Control;
            this.labelSector.Location = new System.Drawing.Point(110, 18);
            this.labelSector.Name = "labelSector";
            this.labelSector.Size = new System.Drawing.Size(39, 15);
            this.labelSector.TabIndex = 5;
            this.labelSector.Text = "sector";
            this.labelSector.Visible = false;
            // 
            // labelNewSpeed
            // 
            this.labelNewSpeed.AutoSize = true;
            this.labelNewSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.labelNewSpeed.Location = new System.Drawing.Point(374, 33);
            this.labelNewSpeed.Name = "labelNewSpeed";
            this.labelNewSpeed.Size = new System.Drawing.Size(61, 15);
            this.labelNewSpeed.TabIndex = 4;
            this.labelNewSpeed.Text = "newSpeed";
            this.labelNewSpeed.Visible = false;
            // 
            // labelCurrYVal
            // 
            this.labelCurrYVal.AutoSize = true;
            this.labelCurrYVal.BackColor = System.Drawing.SystemColors.Control;
            this.labelCurrYVal.Location = new System.Drawing.Point(374, 3);
            this.labelCurrYVal.Name = "labelCurrYVal";
            this.labelCurrYVal.Size = new System.Drawing.Size(52, 15);
            this.labelCurrYVal.TabIndex = 3;
            this.labelCurrYVal.Text = "CurrYVal";
            this.labelCurrYVal.Visible = false;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.BackColor = System.Drawing.SystemColors.Control;
            this.labelY.Location = new System.Drawing.Point(130, 3);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 15);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Y";
            this.labelY.Visible = false;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.SystemColors.Control;
            this.labelX.Location = new System.Drawing.Point(110, 3);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 15);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X";
            this.labelX.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wind Speed";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 50;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // checkDev
            // 
            this.checkDev.AutoSize = true;
            this.checkDev.Location = new System.Drawing.Point(12, 420);
            this.checkDev.Name = "checkDev";
            this.checkDev.Size = new System.Drawing.Size(79, 19);
            this.checkDev.TabIndex = 2;
            this.checkDev.Text = "dev mode";
            this.checkDev.UseVisualStyleBackColor = true;
            this.checkDev.CheckedChanged += new System.EventHandler(this.checkDev_CheckedChanged);
            // 
            // WeatherTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(704, 515);
            this.Controls.Add(this.checkDev);
            this.Controls.Add(this.panelMainCanvas);
            this.Controls.Add(this.panelClouds);
            this.Name = "WeatherTool";
            this.Text = "WeatherTool";
            this.Resize += new System.EventHandler(this.WeatherTool_Resize);
            this.panelMainCanvas.ResumeLayout(false);
            this.panelMainCanvas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}