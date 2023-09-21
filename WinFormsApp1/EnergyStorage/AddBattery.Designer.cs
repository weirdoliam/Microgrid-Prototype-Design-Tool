namespace WinFormsApp1.EnergyStorage
{
    partial class AddBattery
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
            groupBoxBattery = new System.Windows.Forms.GroupBox();
            labelCharTime = new System.Windows.Forms.Label();
            labelkWh = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            labelEstimatedCharge = new System.Windows.Forms.Label();
            textBoxCurrent = new System.Windows.Forms.TextBox();
            labelCharge = new System.Windows.Forms.Label();
            textBoxVoltage = new System.Windows.Forms.TextBox();
            labelVoltage = new System.Windows.Forms.Label();
            textBoxPrice = new System.Windows.Forms.TextBox();
            labelPrice = new System.Windows.Forms.Label();
            textBoxLife = new System.Windows.Forms.TextBox();
            textBoxCap = new System.Windows.Forms.TextBox();
            labelCapacity = new System.Windows.Forms.Label();
            labelLife = new System.Windows.Forms.Label();
            labelAmount = new System.Windows.Forms.Label();
            textBoxQuantity = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            comboBoxType = new System.Windows.Forms.ComboBox();
            buttonAdd = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            groupBoxBattery.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxBattery
            // 
            groupBoxBattery.Controls.Add(labelCharTime);
            groupBoxBattery.Controls.Add(labelkWh);
            groupBoxBattery.Controls.Add(label3);
            groupBoxBattery.Controls.Add(labelEstimatedCharge);
            groupBoxBattery.Controls.Add(textBoxCurrent);
            groupBoxBattery.Controls.Add(labelCharge);
            groupBoxBattery.Controls.Add(textBoxVoltage);
            groupBoxBattery.Controls.Add(labelVoltage);
            groupBoxBattery.Controls.Add(textBoxPrice);
            groupBoxBattery.Controls.Add(labelPrice);
            groupBoxBattery.Controls.Add(textBoxLife);
            groupBoxBattery.Controls.Add(textBoxCap);
            groupBoxBattery.Controls.Add(labelCapacity);
            groupBoxBattery.Controls.Add(labelLife);
            groupBoxBattery.Controls.Add(labelAmount);
            groupBoxBattery.Controls.Add(textBoxQuantity);
            groupBoxBattery.Controls.Add(label2);
            groupBoxBattery.Controls.Add(comboBoxType);
            groupBoxBattery.Location = new System.Drawing.Point(12, 12);
            groupBoxBattery.Name = "groupBoxBattery";
            groupBoxBattery.Size = new System.Drawing.Size(531, 221);
            groupBoxBattery.TabIndex = 5;
            groupBoxBattery.TabStop = false;
            groupBoxBattery.Text = "Energy Storage";
            // 
            // labelCharTime
            // 
            labelCharTime.AutoSize = true;
            labelCharTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            labelCharTime.Location = new System.Drawing.Point(169, 154);
            labelCharTime.Name = "labelCharTime";
            labelCharTime.Size = new System.Drawing.Size(23, 15);
            labelCharTime.TabIndex = 23;
            labelCharTime.Text = "0 h";
            // 
            // labelkWh
            // 
            labelkWh.AutoSize = true;
            labelkWh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            labelkWh.Location = new System.Drawing.Point(167, 182);
            labelkWh.Name = "labelkWh";
            labelkWh.Size = new System.Drawing.Size(40, 15);
            labelkWh.TabIndex = 22;
            labelkWh.Text = "0 kWh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(34, 182);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 15);
            label3.TabIndex = 21;
            label3.Text = "kWh rating: ";
            // 
            // labelEstimatedCharge
            // 
            labelEstimatedCharge.AutoSize = true;
            labelEstimatedCharge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            labelEstimatedCharge.Location = new System.Drawing.Point(34, 154);
            labelEstimatedCharge.Name = "labelEstimatedCharge";
            labelEstimatedCharge.Size = new System.Drawing.Size(133, 15);
            labelEstimatedCharge.TabIndex = 19;
            labelEstimatedCharge.Text = "Charging Time (Hours): ";
            // 
            // textBoxCurrent
            // 
            textBoxCurrent.Location = new System.Drawing.Point(169, 120);
            textBoxCurrent.Name = "textBoxCurrent";
            textBoxCurrent.Size = new System.Drawing.Size(139, 23);
            textBoxCurrent.TabIndex = 18;
            textBoxCurrent.KeyPress += textBoxCurrent_KeyPress;
            // 
            // labelCharge
            // 
            labelCharge.AutoSize = true;
            labelCharge.Location = new System.Drawing.Point(6, 123);
            labelCharge.Name = "labelCharge";
            labelCharge.Size = new System.Drawing.Size(122, 15);
            labelCharge.TabIndex = 17;
            labelCharge.Text = "Max C/D Current (A): ";
            // 
            // textBoxVoltage
            // 
            textBoxVoltage.Location = new System.Drawing.Point(169, 89);
            textBoxVoltage.Name = "textBoxVoltage";
            textBoxVoltage.Size = new System.Drawing.Size(139, 23);
            textBoxVoltage.TabIndex = 16;
            textBoxVoltage.KeyPress += textBoxVoltage_KeyPress;
            // 
            // labelVoltage
            // 
            labelVoltage.AutoSize = true;
            labelVoltage.Location = new System.Drawing.Point(6, 92);
            labelVoltage.Name = "labelVoltage";
            labelVoltage.Size = new System.Drawing.Size(67, 15);
            labelVoltage.TabIndex = 15;
            labelVoltage.Text = "Voltage (V):";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(436, 58);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(89, 23);
            textBoxPrice.TabIndex = 12;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new System.Drawing.Point(314, 61);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(39, 15);
            labelPrice.TabIndex = 11;
            labelPrice.Text = "Price: ";
            // 
            // textBoxLife
            // 
            textBoxLife.Location = new System.Drawing.Point(436, 27);
            textBoxLife.Name = "textBoxLife";
            textBoxLife.Size = new System.Drawing.Size(89, 23);
            textBoxLife.TabIndex = 10;
            // 
            // textBoxCap
            // 
            textBoxCap.ImeMode = System.Windows.Forms.ImeMode.On;
            textBoxCap.Location = new System.Drawing.Point(169, 58);
            textBoxCap.Name = "textBoxCap";
            textBoxCap.Size = new System.Drawing.Size(139, 23);
            textBoxCap.TabIndex = 8;
            textBoxCap.KeyPress += textBoxCap_KeyPress;
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.Location = new System.Drawing.Point(6, 61);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new System.Drawing.Size(81, 15);
            labelCapacity.TabIndex = 7;
            labelCapacity.Text = "Capacity (W): ";
            // 
            // labelLife
            // 
            labelLife.AutoSize = true;
            labelLife.Location = new System.Drawing.Point(314, 30);
            labelLife.Name = "labelLife";
            labelLife.Size = new System.Drawing.Size(116, 15);
            labelLife.TabIndex = 6;
            labelLife.Text = "Life Cycle (Months): ";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new System.Drawing.Point(314, 92);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new System.Drawing.Size(34, 15);
            labelAmount.TabIndex = 2;
            labelAmount.Text = "# of: ";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new System.Drawing.Point(436, 89);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new System.Drawing.Size(89, 23);
            textBoxQuantity.TabIndex = 3;
            textBoxQuantity.Text = "1";
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
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "3kW Lithium-Ion", "5kW Lithium-Ion", "6kW Lithium-Ion" });
            comboBoxType.Location = new System.Drawing.Point(169, 27);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(139, 23);
            comboBoxType.TabIndex = 1;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(12, 235);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(257, 23);
            buttonAdd.TabIndex = 20;
            buttonAdd.Text = "Add to grid";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(286, 235);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(257, 23);
            buttonCancel.TabIndex = 21;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddBattery
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(557, 270);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxBattery);
            Name = "AddBattery";
            Text = "AddBattery";
            groupBoxBattery.ResumeLayout(false);
            groupBoxBattery.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBattery;
        private System.Windows.Forms.TextBox textBoxVoltage;
        private System.Windows.Forms.Label labelVoltage;
        private System.Windows.Forms.Label labelkWh;
        private System.Windows.Forms.TextBox textBoxCurrent;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxLife;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.TextBox textBoxCap;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelLife;
        private System.Windows.Forms.Label labelDim;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelCharge;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelEstimatedCharge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelCharTime;
    }
}