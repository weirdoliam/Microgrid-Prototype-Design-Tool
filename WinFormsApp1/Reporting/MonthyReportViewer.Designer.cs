namespace WinFormsApp1.Reporting
{
    partial class MonthyReportViewer
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            panelX = new System.Windows.Forms.Panel();
            mainCanvas = new System.Windows.Forms.Panel();
            panelY = new System.Windows.Forms.Panel();
            checkedListBoxData = new System.Windows.Forms.CheckedListBox();
            textBoxMax = new System.Windows.Forms.TextBox();
            buttonSetMax = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelX);
            groupBox1.Controls.Add(mainCanvas);
            groupBox1.Controls.Add(panelY);
            groupBox1.Controls.Add(checkedListBoxData);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1657, 499);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Graphing";
            // 
            // panelX
            // 
            panelX.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelX.BackColor = System.Drawing.SystemColors.Control;
            panelX.Location = new System.Drawing.Point(111, 459);
            panelX.Name = "panelX";
            panelX.Size = new System.Drawing.Size(1546, 40);
            panelX.TabIndex = 3;
            panelX.Paint += panelX_Paint;
            // 
            // mainCanvas
            // 
            mainCanvas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            mainCanvas.BackColor = System.Drawing.SystemColors.Window;
            mainCanvas.Location = new System.Drawing.Point(168, 19);
            mainCanvas.Name = "mainCanvas";
            mainCanvas.Size = new System.Drawing.Size(1489, 441);
            mainCanvas.TabIndex = 0;
            mainCanvas.Paint += mainCanvas_Paint;
            // 
            // panelY
            // 
            panelY.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panelY.BackColor = System.Drawing.SystemColors.Control;
            panelY.Location = new System.Drawing.Point(111, 19);
            panelY.Name = "panelY";
            panelY.Size = new System.Drawing.Size(59, 441);
            panelY.TabIndex = 2;
            panelY.Paint += panelY_Paint;
            // 
            // checkedListBoxData
            // 
            checkedListBoxData.Dock = System.Windows.Forms.DockStyle.Left;
            checkedListBoxData.FormattingEnabled = true;
            checkedListBoxData.Location = new System.Drawing.Point(3, 19);
            checkedListBoxData.Name = "checkedListBoxData";
            checkedListBoxData.Size = new System.Drawing.Size(108, 477);
            checkedListBoxData.TabIndex = 1;
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new System.Drawing.Point(111, 506);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new System.Drawing.Size(100, 23);
            textBoxMax.TabIndex = 4;
            // 
            // buttonSetMax
            // 
            buttonSetMax.Location = new System.Drawing.Point(3, 505);
            buttonSetMax.Name = "buttonSetMax";
            buttonSetMax.Size = new System.Drawing.Size(102, 23);
            buttonSetMax.TabIndex = 5;
            buttonSetMax.Text = "go";
            buttonSetMax.UseVisualStyleBackColor = true;
            buttonSetMax.Click += buttonSetMax_Click;
            // 
            // MonthyReportViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1657, 681);
            Controls.Add(buttonSetMax);
            Controls.Add(textBoxMax);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MonthyReportViewer";
            Opacity = 0.99D;
            Text = "Monthy Report Viewer";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelX;
        private System.Windows.Forms.Panel mainCanvas;
        private System.Windows.Forms.Panel panelY;
        private System.Windows.Forms.CheckedListBox checkedListBoxData;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Button buttonSetMax;
    }
}