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
            mainCanvas = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // mainCanvas
            // 
            mainCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            mainCanvas.Location = new System.Drawing.Point(0, 0);
            mainCanvas.Name = "mainCanvas";
            mainCanvas.Size = new System.Drawing.Size(800, 450);
            mainCanvas.TabIndex = 0;
            mainCanvas.Paint += mainCanvas_Paint;
            mainCanvas.Resize += mainCanvas_Resize;
            // 
            // DailyReportViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(mainCanvas);
            Name = "DailyReportViewer";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainCanvas;
    }
}