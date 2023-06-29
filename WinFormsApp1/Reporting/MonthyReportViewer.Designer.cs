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
            listBox1 = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(12, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(148, 409);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Totals";
            // 
            // MonthyReportViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(987, 465);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "MonthyReportViewer";
            Text = "MonthyReportViewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}