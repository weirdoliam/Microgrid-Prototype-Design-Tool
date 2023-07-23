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
            labelAmount = new System.Windows.Forms.Label();
            textBoxQuantity = new System.Windows.Forms.TextBox();
            groupBoxSolar = new System.Windows.Forms.GroupBox();
            textBoxCells = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBoxL = new System.Windows.Forms.TextBox();
            textBoxPrice = new System.Windows.Forms.TextBox();
            labelPrice = new System.Windows.Forms.Label();
            textBoxWatts = new System.Windows.Forms.TextBox();
            textBoxW = new System.Windows.Forms.TextBox();
            textBoxMat = new System.Windows.Forms.TextBox();
            labelMat = new System.Windows.Forms.Label();
            labelWatts = new System.Windows.Forms.Label();
            labelDim = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            comboBoxSolarType = new System.Windows.Forms.ComboBox();
            button2 = new System.Windows.Forms.Button();
            groupBoxSolar.SuspendLayout();
            SuspendLayout();
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new System.Drawing.Point(6, 210);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new System.Drawing.Size(34, 15);
            labelAmount.TabIndex = 2;
            labelAmount.Text = "# of: ";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new System.Drawing.Point(94, 207);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new System.Drawing.Size(39, 23);
            textBoxQuantity.TabIndex = 3;
            textBoxQuantity.Text = "0";
            // 
            // groupBoxSolar
            // 
            groupBoxSolar.Controls.Add(textBoxCells);
            groupBoxSolar.Controls.Add(label3);
            groupBoxSolar.Controls.Add(label1);
            groupBoxSolar.Controls.Add(textBoxL);
            groupBoxSolar.Controls.Add(textBoxPrice);
            groupBoxSolar.Controls.Add(labelPrice);
            groupBoxSolar.Controls.Add(textBoxWatts);
            groupBoxSolar.Controls.Add(textBoxW);
            groupBoxSolar.Controls.Add(textBoxMat);
            groupBoxSolar.Controls.Add(labelMat);
            groupBoxSolar.Controls.Add(labelWatts);
            groupBoxSolar.Controls.Add(labelDim);
            groupBoxSolar.Controls.Add(labelAmount);
            groupBoxSolar.Controls.Add(textBoxQuantity);
            groupBoxSolar.Controls.Add(label2);
            groupBoxSolar.Controls.Add(comboBoxSolarType);
            groupBoxSolar.Location = new System.Drawing.Point(12, 12);
            groupBoxSolar.Name = "groupBoxSolar";
            groupBoxSolar.Size = new System.Drawing.Size(246, 249);
            groupBoxSolar.TabIndex = 4;
            groupBoxSolar.TabStop = false;
            groupBoxSolar.Text = "Solar Panel Properties";
            // 
            // textBoxCells
            // 
            textBoxCells.Location = new System.Drawing.Point(94, 117);
            textBoxCells.Name = "textBoxCells";
            textBoxCells.Size = new System.Drawing.Size(146, 23);
            textBoxCells.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 120);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 15);
            label3.TabIndex = 15;
            label3.Text = "Cells:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(159, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(16, 20);
            label1.TabIndex = 14;
            label1.Text = "x";
            // 
            // textBoxL
            // 
            textBoxL.Location = new System.Drawing.Point(177, 87);
            textBoxL.Name = "textBoxL";
            textBoxL.Size = new System.Drawing.Size(63, 23);
            textBoxL.TabIndex = 13;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(94, 177);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(146, 23);
            textBoxPrice.TabIndex = 12;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new System.Drawing.Point(6, 180);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(39, 15);
            labelPrice.TabIndex = 11;
            labelPrice.Text = "Price: ";
            // 
            // textBoxWatts
            // 
            textBoxWatts.Location = new System.Drawing.Point(94, 147);
            textBoxWatts.Name = "textBoxWatts";
            textBoxWatts.Size = new System.Drawing.Size(146, 23);
            textBoxWatts.TabIndex = 10;
            // 
            // textBoxW
            // 
            textBoxW.Location = new System.Drawing.Point(94, 87);
            textBoxW.Name = "textBoxW";
            textBoxW.Size = new System.Drawing.Size(63, 23);
            textBoxW.TabIndex = 9;
            // 
            // textBoxMat
            // 
            textBoxMat.Location = new System.Drawing.Point(94, 57);
            textBoxMat.Name = "textBoxMat";
            textBoxMat.Size = new System.Drawing.Size(146, 23);
            textBoxMat.TabIndex = 8;
            // 
            // labelMat
            // 
            labelMat.AutoSize = true;
            labelMat.Location = new System.Drawing.Point(6, 60);
            labelMat.Name = "labelMat";
            labelMat.Size = new System.Drawing.Size(56, 15);
            labelMat.TabIndex = 7;
            labelMat.Text = "Material: ";
            // 
            // labelWatts
            // 
            labelWatts.AutoSize = true;
            labelWatts.Location = new System.Drawing.Point(6, 150);
            labelWatts.Name = "labelWatts";
            labelWatts.Size = new System.Drawing.Size(43, 15);
            labelWatts.TabIndex = 6;
            labelWatts.Text = "Watts: ";
            // 
            // labelDim
            // 
            labelDim.AutoSize = true;
            labelDim.Location = new System.Drawing.Point(6, 90);
            labelDim.Name = "labelDim";
            labelDim.Size = new System.Drawing.Size(75, 15);
            labelDim.TabIndex = 5;
            labelDim.Text = "Dimensions: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Type: ";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxSolarType
            // 
            comboBoxSolarType.FormattingEnabled = true;
            comboBoxSolarType.Items.AddRange(new object[] { "Residential (60 Cells)", "Commercial (72 Cells)" });
            comboBoxSolarType.Location = new System.Drawing.Point(94, 27);
            comboBoxSolarType.Name = "comboBoxSolarType";
            comboBoxSolarType.Size = new System.Drawing.Size(146, 23);
            comboBoxSolarType.TabIndex = 1;
            comboBoxSolarType.SelectedIndexChanged += comboBoxSolarType_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(12, 267);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(246, 23);
            button2.TabIndex = 4;
            button2.Text = "&Add to Grid";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormGenArray
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(269, 302);
            Controls.Add(groupBoxSolar);
            Controls.Add(button2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FormGenArray";
            Text = "New Energy Generation";
            groupBoxSolar.ResumeLayout(false);
            groupBoxSolar.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBoxWatts;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.TextBox textBoxMat;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxCells;
        private System.Windows.Forms.Label label3;
    }
}