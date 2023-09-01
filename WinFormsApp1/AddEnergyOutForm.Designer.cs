namespace WinFormsApp1
{
    partial class AddEnergyOutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEnergyOutForm));
            groupBox2 = new System.Windows.Forms.GroupBox();
            textBoxLocation = new System.Windows.Forms.TextBox();
            labelK = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBoxIncome = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            numericUpDownChildren = new System.Windows.Forms.NumericUpDown();
            numericUpDownAdults = new System.Windows.Forms.NumericUpDown();
            buttonAdd = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            checkedLBHM = new System.Windows.Forms.CheckedListBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            button1 = new System.Windows.Forms.Button();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            openFileDialogHouse = new System.Windows.Forms.OpenFileDialog();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChildren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdults).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxLocation);
            groupBox2.Controls.Add(labelK);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxIncome);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDownChildren);
            groupBox2.Controls.Add(numericUpDownAdults);
            groupBox2.Controls.Add(buttonAdd);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(checkedLBHM);
            groupBox2.Location = new System.Drawing.Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(200, 321);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "House Model";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new System.Drawing.Point(6, 260);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new System.Drawing.Size(100, 23);
            textBoxLocation.TabIndex = 13;
            // 
            // labelK
            // 
            labelK.AutoSize = true;
            labelK.Location = new System.Drawing.Point(62, 219);
            labelK.Name = "labelK";
            labelK.Size = new System.Drawing.Size(13, 15);
            labelK.TabIndex = 12;
            labelK.Text = "k";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(8, 242);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(143, 15);
            label6.TabIndex = 11;
            label6.Text = "Location (City, Rural etc): ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(8, 195);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(121, 15);
            label5.TabIndex = 9;
            label5.Text = "Income (Thousands): ";
            // 
            // textBoxIncome
            // 
            textBoxIncome.Location = new System.Drawing.Point(8, 216);
            textBoxIncome.Name = "textBoxIncome";
            textBoxIncome.Size = new System.Drawing.Size(49, 23);
            textBoxIncome.TabIndex = 8;
            textBoxIncome.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(81, 147);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Children: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 147);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Adults: ";
            // 
            // numericUpDownChildren
            // 
            numericUpDownChildren.Location = new System.Drawing.Point(82, 169);
            numericUpDownChildren.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownChildren.Name = "numericUpDownChildren";
            numericUpDownChildren.Size = new System.Drawing.Size(69, 23);
            numericUpDownChildren.TabIndex = 5;
            // 
            // numericUpDownAdults
            // 
            numericUpDownAdults.Location = new System.Drawing.Point(6, 169);
            numericUpDownAdults.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownAdults.Name = "numericUpDownAdults";
            numericUpDownAdults.Size = new System.Drawing.Size(69, 23);
            numericUpDownAdults.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(5, 289);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(189, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Use pre-generated load";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 15);
            label2.TabIndex = 3;
            label2.Text = "Electricity Details: ";
            // 
            // checkedLBHM
            // 
            checkedLBHM.FormattingEnabled = true;
            checkedLBHM.Items.AddRange(new object[] { "Heatpump", "Electric Cooking", "Mains Cooking", "Bottled Gas Cooking", "Electric Water Heating", "Mains Water Heating", "Wood Water Heating", "Electric Space Heating", "Mains Space Heating", "Wood Space Heating", "Fossil Fuel Space Heating" });
            checkedLBHM.Location = new System.Drawing.Point(6, 41);
            checkedLBHM.Name = "checkedLBHM";
            checkedLBHM.Size = new System.Drawing.Size(188, 94);
            checkedLBHM.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new System.Drawing.Point(218, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(201, 321);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Use Imported Load";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(6, 289);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(189, 23);
            button1.TabIndex = 1;
            button1.Text = "Import Custom Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(0, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(201, 235);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // openFileDialogHouse
            // 
            openFileDialogHouse.FileName = "openFileDialog1";
            // 
            // AddEnergyOutForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(431, 340);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEnergyOutForm";
            Text = "Add Houses";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChildren).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdults).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedLBHM;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownChildren;
        private System.Windows.Forms.NumericUpDown numericUpDownAdults;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialogHouse;
    }
}