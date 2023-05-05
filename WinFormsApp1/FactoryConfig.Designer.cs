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
            this.panelParticulars = new System.Windows.Forms.Panel();
            this.buttonNewItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxMachines = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPreLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxMachineTimes = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonClearImport = new System.Windows.Forms.Button();
            this.panelParticulars.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelParticulars
            // 
            this.panelParticulars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelParticulars.Controls.Add(this.buttonNewItem);
            this.panelParticulars.Controls.Add(this.label2);
            this.panelParticulars.Controls.Add(this.listBoxMachines);
            this.panelParticulars.Controls.Add(this.textBoxName);
            this.panelParticulars.Controls.Add(this.label1);
            this.panelParticulars.Location = new System.Drawing.Point(7, 12);
            this.panelParticulars.Name = "panelParticulars";
            this.panelParticulars.Size = new System.Drawing.Size(274, 265);
            this.panelParticulars.TabIndex = 0;
            // 
            // buttonNewItem
            // 
            this.buttonNewItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonNewItem.Location = new System.Drawing.Point(0, 230);
            this.buttonNewItem.Name = "buttonNewItem";
            this.buttonNewItem.Size = new System.Drawing.Size(274, 35);
            this.buttonNewItem.TabIndex = 3;
            this.buttonNewItem.Text = "New Machine";
            this.buttonNewItem.UseVisualStyleBackColor = true;
            this.buttonNewItem.Click += new System.EventHandler(this.buttonNewItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Machinery: ";
            // 
            // listBoxMachines
            // 
            this.listBoxMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMachines.FormattingEnabled = true;
            this.listBoxMachines.ItemHeight = 15;
            this.listBoxMachines.Location = new System.Drawing.Point(0, 55);
            this.listBoxMachines.Name = "listBoxMachines";
            this.listBoxMachines.Size = new System.Drawing.Size(272, 169);
            this.listBoxMachines.TabIndex = 2;
            this.listBoxMachines.SelectedIndexChanged += new System.EventHandler(this.listBoxMachines_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(69, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(201, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonApply.Location = new System.Drawing.Point(7, 493);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(94, 23);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply + Close";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(181, 493);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonClearImport);
            this.panel1.Controls.Add(this.buttonPreLoad);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listBoxMachineTimes);
            this.panel1.Location = new System.Drawing.Point(7, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 199);
            this.panel1.TabIndex = 3;
            // 
            // buttonPreLoad
            // 
            this.buttonPreLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreLoad.Location = new System.Drawing.Point(89, 160);
            this.buttonPreLoad.Name = "buttonPreLoad";
            this.buttonPreLoad.Size = new System.Drawing.Size(93, 35);
            this.buttonPreLoad.TabIndex = 5;
            this.buttonPreLoad.Text = "Import Load";
            this.buttonPreLoad.UseVisualStyleBackColor = true;
            this.buttonPreLoad.Click += new System.EventHandler(this.buttonPreLoad_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(1, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "New Range";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Machinery Details:";
            // 
            // listBoxMachineTimes
            // 
            this.listBoxMachineTimes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMachineTimes.FormattingEnabled = true;
            this.listBoxMachineTimes.ItemHeight = 15;
            this.listBoxMachineTimes.Location = new System.Drawing.Point(1, 21);
            this.listBoxMachineTimes.Name = "listBoxMachineTimes";
            this.listBoxMachineTimes.Size = new System.Drawing.Size(273, 139);
            this.listBoxMachineTimes.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonClearImport
            // 
            this.buttonClearImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearImport.Location = new System.Drawing.Point(179, 160);
            this.buttonClearImport.Name = "buttonClearImport";
            this.buttonClearImport.Size = new System.Drawing.Size(93, 35);
            this.buttonClearImport.TabIndex = 6;
            this.buttonClearImport.Text = "Clear Import";
            this.buttonClearImport.UseVisualStyleBackColor = true;
            this.buttonClearImport.Click += new System.EventHandler(this.buttonClearImport_Click);
            // 
            // FactoryConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.panelParticulars);
            this.Name = "FactoryConfig";
            this.Text = "FactoryConfig";
            this.panelParticulars.ResumeLayout(false);
            this.panelParticulars.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}