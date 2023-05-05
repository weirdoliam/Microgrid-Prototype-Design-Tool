namespace WinFormsApp1
{
    partial class FormGenArray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenArray));
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.groupBoxSolar = new System.Windows.Forms.GroupBox();
            this.labelMat = new System.Windows.Forms.Label();
            this.labelWatts = new System.Windows.Forms.Label();
            this.labelDim = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSolarType = new System.Windows.Forms.ComboBox();
            this.groupBoxSolar.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(6, 59);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(34, 15);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "# of: ";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(49, 56);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(39, 23);
            this.textBoxQuantity.TabIndex = 3;
            this.textBoxQuantity.Text = "0";
            // 
            // groupBoxSolar
            // 
            this.groupBoxSolar.Controls.Add(this.labelMat);
            this.groupBoxSolar.Controls.Add(this.labelWatts);
            this.groupBoxSolar.Controls.Add(this.labelDim);
            this.groupBoxSolar.Controls.Add(this.button2);
            this.groupBoxSolar.Controls.Add(this.labelAmount);
            this.groupBoxSolar.Controls.Add(this.textBoxQuantity);
            this.groupBoxSolar.Controls.Add(this.label2);
            this.groupBoxSolar.Controls.Add(this.comboBoxSolarType);
            this.groupBoxSolar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSolar.Name = "groupBoxSolar";
            this.groupBoxSolar.Size = new System.Drawing.Size(235, 197);
            this.groupBoxSolar.TabIndex = 4;
            this.groupBoxSolar.TabStop = false;
            this.groupBoxSolar.Text = "Solar Panel Properties";
            // 
            // labelMat
            // 
            this.labelMat.AutoSize = true;
            this.labelMat.Location = new System.Drawing.Point(6, 84);
            this.labelMat.Name = "labelMat";
            this.labelMat.Size = new System.Drawing.Size(56, 15);
            this.labelMat.TabIndex = 7;
            this.labelMat.Text = "Material: ";
            // 
            // labelWatts
            // 
            this.labelWatts.AutoSize = true;
            this.labelWatts.Location = new System.Drawing.Point(6, 135);
            this.labelWatts.Name = "labelWatts";
            this.labelWatts.Size = new System.Drawing.Size(43, 15);
            this.labelWatts.TabIndex = 6;
            this.labelWatts.Text = "Watts: ";
            // 
            // labelDim
            // 
            this.labelDim.AutoSize = true;
            this.labelDim.Location = new System.Drawing.Point(6, 108);
            this.labelDim.Name = "labelDim";
            this.labelDim.Size = new System.Drawing.Size(75, 15);
            this.labelDim.TabIndex = 5;
            this.labelDim.Text = "Dimensions: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Add to Grid";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxSolarType
            // 
            this.comboBoxSolarType.FormattingEnabled = true;
            this.comboBoxSolarType.Items.AddRange(new object[] {
            "Residential (60 Cells)",
            "Commercial (72 Cells)"});
            this.comboBoxSolarType.Location = new System.Drawing.Point(49, 27);
            this.comboBoxSolarType.Name = "comboBoxSolarType";
            this.comboBoxSolarType.Size = new System.Drawing.Size(145, 23);
            this.comboBoxSolarType.TabIndex = 1;
            this.comboBoxSolarType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSolarType_SelectedIndexChanged);
            // 
            // FormGenArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(259, 219);
            this.Controls.Add(this.groupBoxSolar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGenArray";
            this.Text = "New Energy Generation";
            this.groupBoxSolar.ResumeLayout(false);
            this.groupBoxSolar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.GroupBox groupBoxSolar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSolarType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelWatts;
        private System.Windows.Forms.Label labelDim;
        private System.Windows.Forms.Label labelMat;
    }
}