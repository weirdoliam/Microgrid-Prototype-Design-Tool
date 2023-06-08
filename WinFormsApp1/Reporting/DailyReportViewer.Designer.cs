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
            panelX = new System.Windows.Forms.Panel();
            panelY = new System.Windows.Forms.Panel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            richTextBoxResponce = new System.Windows.Forms.RichTextBox();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // mainCanvas
            // 
            mainCanvas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            mainCanvas.BackColor = System.Drawing.SystemColors.Window;
            mainCanvas.Location = new System.Drawing.Point(168, 19);
            mainCanvas.Name = "mainCanvas";
            mainCanvas.Size = new System.Drawing.Size(839, 367);
            mainCanvas.TabIndex = 0;
            mainCanvas.Paint += mainCanvas_Paint;
            mainCanvas.Resize += mainCanvas_Resize;
            // 
            // checkedListBoxData
            // 
            checkedListBoxData.Dock = System.Windows.Forms.DockStyle.Left;
            checkedListBoxData.FormattingEnabled = true;
            checkedListBoxData.Location = new System.Drawing.Point(3, 19);
            checkedListBoxData.Name = "checkedListBoxData";
            checkedListBoxData.Size = new System.Drawing.Size(108, 390);
            checkedListBoxData.TabIndex = 1;
            checkedListBoxData.Click += checkedListBoxData_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mainCanvas);
            groupBox1.Controls.Add(panelX);
            groupBox1.Controls.Add(panelY);
            groupBox1.Controls.Add(checkedListBoxData);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1010, 412);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Graphing";
            // 
            // panelX
            // 
            panelX.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelX.BackColor = System.Drawing.SystemColors.Control;
            panelX.Location = new System.Drawing.Point(168, 385);
            panelX.Name = "panelX";
            panelX.Size = new System.Drawing.Size(839, 27);
            panelX.TabIndex = 3;
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
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(richTextBoxResponce);
            groupBox2.Location = new System.Drawing.Point(3, 418);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1007, 212);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 15);
            label1.TabIndex = 1;
            label1.Text = "AI-Generated Report:";
            // 
            // richTextBoxResponce
            // 
            richTextBoxResponce.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBoxResponce.Location = new System.Drawing.Point(6, 91);
            richTextBoxResponce.Name = "richTextBoxResponce";
            richTextBoxResponce.Size = new System.Drawing.Size(995, 110);
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
            ClientSize = new System.Drawing.Size(1010, 631);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DailyReportViewer";
            Text = "Single Day Report";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
    }
}