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
            SuspendLayout();
            // 
            // buttonEnergyBalance
            // 
            buttonEnergyBalance.Location = new System.Drawing.Point(12, 12);
            buttonEnergyBalance.Name = "buttonEnergyBalance";
            buttonEnergyBalance.Size = new System.Drawing.Size(111, 23);
            buttonEnergyBalance.TabIndex = 0;
            buttonEnergyBalance.Text = "Energy Balance";
            buttonEnergyBalance.UseVisualStyleBackColor = true;
            buttonEnergyBalance.Click += buttonEnergyBalance_Click;
            // 
            // YearlyPerformance
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(396, 45);
            Controls.Add(buttonEnergyBalance);
            Name = "YearlyPerformance";
            Text = "YearlyPerformance";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonEnergyBalance;
    }
}