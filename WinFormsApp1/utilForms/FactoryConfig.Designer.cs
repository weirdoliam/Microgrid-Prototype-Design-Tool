namespace WinFormsApp1
{
    partial class FactoryConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactoryConfig));
            panelParticulars = new System.Windows.Forms.Panel();
            buttonNewItem = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            listBoxMachines = new System.Windows.Forms.ListBox();
            textBoxName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            buttonApply = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            listBoxMachineTimes = new System.Windows.Forms.ListBox();
            buttonClearImport = new System.Windows.Forms.Button();
            buttonPreLoad = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            buttonComp = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            folderBrowserDialogMain = new System.Windows.Forms.FolderBrowserDialog();
            panel2 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            panelParticulars.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelParticulars
            // 
            panelParticulars.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelParticulars.Controls.Add(buttonNewItem);
            panelParticulars.Controls.Add(label2);
            panelParticulars.Controls.Add(listBoxMachines);
            panelParticulars.Location = new System.Drawing.Point(7, 39);
            panelParticulars.Name = "panelParticulars";
            panelParticulars.Size = new System.Drawing.Size(265, 238);
            panelParticulars.TabIndex = 0;
            // 
            // buttonNewItem
            // 
            buttonNewItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonNewItem.Location = new System.Drawing.Point(0, 19);
            buttonNewItem.Name = "buttonNewItem";
            buttonNewItem.Size = new System.Drawing.Size(265, 35);
            buttonNewItem.TabIndex = 3;
            buttonNewItem.Text = "New Machine";
            buttonNewItem.UseVisualStyleBackColor = true;
            buttonNewItem.Click += buttonNewItem_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 1);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(114, 15);
            label2.TabIndex = 3;
            label2.Text = "Custom Machinery: ";
            // 
            // listBoxMachines
            // 
            listBoxMachines.Dock = System.Windows.Forms.DockStyle.Bottom;
            listBoxMachines.FormattingEnabled = true;
            listBoxMachines.ItemHeight = 15;
            listBoxMachines.Location = new System.Drawing.Point(0, 54);
            listBoxMachines.Name = "listBoxMachines";
            listBoxMachines.Size = new System.Drawing.Size(265, 184);
            listBoxMachines.TabIndex = 2;
            listBoxMachines.SelectedIndexChanged += listBoxMachines_SelectedIndexChanged;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxName.Location = new System.Drawing.Point(48, 6);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(224, 23);
            textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name: ";
            // 
            // buttonApply
            // 
            buttonApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            buttonApply.Location = new System.Drawing.Point(7, 518);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new System.Drawing.Size(94, 23);
            buttonApply.TabIndex = 1;
            buttonApply.Text = "Apply + Close";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            buttonCancel.Location = new System.Drawing.Point(445, 518);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(100, 23);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(listBoxMachineTimes);
            panel1.Location = new System.Drawing.Point(7, 283);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(265, 199);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            button1.Location = new System.Drawing.Point(0, 28);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(265, 32);
            button1.TabIndex = 4;
            button1.Text = "New Time Range";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 5);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "Machinery Details:";
            // 
            // listBoxMachineTimes
            // 
            listBoxMachineTimes.Dock = System.Windows.Forms.DockStyle.Bottom;
            listBoxMachineTimes.FormattingEnabled = true;
            listBoxMachineTimes.ItemHeight = 15;
            listBoxMachineTimes.Location = new System.Drawing.Point(0, 60);
            listBoxMachineTimes.Name = "listBoxMachineTimes";
            listBoxMachineTimes.Size = new System.Drawing.Size(265, 139);
            listBoxMachineTimes.TabIndex = 4;
            // 
            // buttonClearImport
            // 
            buttonClearImport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            buttonClearImport.Location = new System.Drawing.Point(445, 489);
            buttonClearImport.Name = "buttonClearImport";
            buttonClearImport.Size = new System.Drawing.Size(100, 23);
            buttonClearImport.TabIndex = 6;
            buttonClearImport.Text = "Clear Load";
            buttonClearImport.UseVisualStyleBackColor = true;
            buttonClearImport.Click += buttonClearImport_Click;
            // 
            // buttonPreLoad
            // 
            buttonPreLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            buttonPreLoad.Location = new System.Drawing.Point(159, 489);
            buttonPreLoad.Name = "buttonPreLoad";
            buttonPreLoad.Size = new System.Drawing.Size(113, 23);
            buttonPreLoad.TabIndex = 5;
            buttonPreLoad.Text = "Generic";
            buttonPreLoad.UseVisualStyleBackColor = true;
            buttonPreLoad.Click += buttonPreLoad_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonComp
            // 
            buttonComp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            buttonComp.Location = new System.Drawing.Point(278, 489);
            buttonComp.Name = "buttonComp";
            buttonComp.Size = new System.Drawing.Size(113, 23);
            buttonComp.TabIndex = 7;
            buttonComp.Text = "Comprehensive";
            buttonComp.UseVisualStyleBackColor = true;
            buttonComp.Click += buttonComp_Click;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 489);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(105, 15);
            label4.TabIndex = 4;
            label4.Text = "Import Load Data: ";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel2.BackColor = System.Drawing.SystemColors.Control;
            panel2.Controls.Add(label5);
            panel2.Location = new System.Drawing.Point(278, 283);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(267, 199);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 5);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 15);
            label5.TabIndex = 0;
            label5.Text = "Data Coverage:";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            richTextBox1.Location = new System.Drawing.Point(278, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(267, 271);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // FactoryConfig
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(550, 562);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(buttonComp);
            Controls.Add(buttonClearImport);
            Controls.Add(textBoxName);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(buttonPreLoad);
            Controls.Add(buttonCancel);
            Controls.Add(buttonApply);
            Controls.Add(panelParticulars);
            Name = "FactoryConfig";
            Text = "FactoryConfig";
            panelParticulars.ResumeLayout(false);
            panelParticulars.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelParticulars;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxMachines;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNewItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxMachineTimes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPreLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonClearImport;
        private System.Windows.Forms.Button buttonComp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}