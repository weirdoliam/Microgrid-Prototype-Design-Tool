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
            label15 = new System.Windows.Forms.Label();
            textBoxHours = new System.Windows.Forms.TextBox();
            textBoxCells = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
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
            tabControl1 = new System.Windows.Forms.TabControl();
            Solar = new System.Windows.Forms.TabPage();
            Wind = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label13 = new System.Windows.Forms.Label();
            quantity = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            price = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            cutoutspeed = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            ratedspeed = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            cutin = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            blades = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            sweptarea = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            rotord = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            power = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            manu = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            name = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            groupBoxSolar.SuspendLayout();
            tabControl1.SuspendLayout();
            Solar.SuspendLayout();
            Wind.SuspendLayout();
            groupBox1.SuspendLayout();
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
            textBoxQuantity.Location = new System.Drawing.Point(168, 206);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new System.Drawing.Size(72, 23);
            textBoxQuantity.TabIndex = 3;
            textBoxQuantity.Text = "1";
            // 
            // groupBoxSolar
            // 
            groupBoxSolar.Controls.Add(label15);
            groupBoxSolar.Controls.Add(textBoxHours);
            groupBoxSolar.Controls.Add(textBoxCells);
            groupBoxSolar.Controls.Add(label3);
            groupBoxSolar.Controls.Add(button2);
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
            groupBoxSolar.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBoxSolar.Location = new System.Drawing.Point(3, 3);
            groupBoxSolar.Name = "groupBoxSolar";
            groupBoxSolar.Size = new System.Drawing.Size(254, 388);
            groupBoxSolar.TabIndex = 4;
            groupBoxSolar.TabStop = false;
            groupBoxSolar.Text = "Solar Panel Properties";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(6, 240);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(156, 15);
            label15.TabIndex = 18;
            label15.Text = "Hours before fully effective: ";
            // 
            // textBoxHours
            // 
            textBoxHours.Location = new System.Drawing.Point(168, 237);
            textBoxHours.Name = "textBoxHours";
            textBoxHours.Size = new System.Drawing.Size(72, 23);
            textBoxHours.TabIndex = 17;
            textBoxHours.Text = "4";
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
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            button2.Location = new System.Drawing.Point(3, 362);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(248, 23);
            button2.TabIndex = 4;
            button2.Text = "&Add Solar Power";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(Solar);
            tabControl1.Controls.Add(Wind);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(268, 422);
            tabControl1.TabIndex = 5;
            // 
            // Solar
            // 
            Solar.Controls.Add(groupBoxSolar);
            Solar.Location = new System.Drawing.Point(4, 24);
            Solar.Name = "Solar";
            Solar.Padding = new System.Windows.Forms.Padding(3);
            Solar.Size = new System.Drawing.Size(260, 394);
            Solar.TabIndex = 0;
            Solar.Text = "Solar";
            Solar.UseVisualStyleBackColor = true;
            // 
            // Wind
            // 
            Wind.Controls.Add(groupBox1);
            Wind.Location = new System.Drawing.Point(4, 24);
            Wind.Name = "Wind";
            Wind.Padding = new System.Windows.Forms.Padding(3);
            Wind.Size = new System.Drawing.Size(260, 394);
            Wind.TabIndex = 1;
            Wind.Text = "Wind";
            Wind.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(quantity);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(price);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cutoutspeed);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(ratedspeed);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cutin);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(blades);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(sweptarea);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(rotord);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(power);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(manu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(254, 388);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Wind Turbine Properties";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(6, 315);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(34, 15);
            label13.TabIndex = 22;
            label13.Text = "# of: ";
            // 
            // quantity
            // 
            quantity.Location = new System.Drawing.Point(141, 312);
            quantity.Name = "quantity";
            quantity.Size = new System.Drawing.Size(108, 23);
            quantity.TabIndex = 21;
            quantity.Text = "1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(6, 286);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(39, 15);
            label14.TabIndex = 20;
            label14.Text = "Price: ";
            // 
            // price
            // 
            price.Location = new System.Drawing.Point(141, 283);
            price.Name = "price";
            price.Size = new System.Drawing.Size(108, 23);
            price.TabIndex = 19;
            price.Text = "250000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(6, 257);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(117, 15);
            label10.TabIndex = 18;
            label10.Text = "Cutout Speed (m/s): ";
            // 
            // cutoutspeed
            // 
            cutoutspeed.Location = new System.Drawing.Point(141, 254);
            cutoutspeed.Name = "cutoutspeed";
            cutoutspeed.Size = new System.Drawing.Size(108, 23);
            cutoutspeed.TabIndex = 17;
            cutoutspeed.Text = "25";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(6, 228);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(110, 15);
            label11.TabIndex = 16;
            label11.Text = "Rated Speed (m/s): ";
            // 
            // ratedspeed
            // 
            ratedspeed.Location = new System.Drawing.Point(141, 225);
            ratedspeed.Name = "ratedspeed";
            ratedspeed.Size = new System.Drawing.Size(108, 23);
            ratedspeed.TabIndex = 15;
            ratedspeed.Text = "13.5";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(6, 199);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(109, 15);
            label12.TabIndex = 14;
            label12.Text = "Cutin Speed (m/s): ";
            // 
            // cutin
            // 
            cutin.Location = new System.Drawing.Point(141, 196);
            cutin.Name = "cutin";
            cutin.Size = new System.Drawing.Size(108, 23);
            cutin.TabIndex = 13;
            cutin.Text = "3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 170);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(47, 15);
            label8.TabIndex = 12;
            label8.Text = "Blades: ";
            // 
            // blades
            // 
            blades.Location = new System.Drawing.Point(141, 167);
            blades.Name = "blades";
            blades.Size = new System.Drawing.Size(108, 23);
            blades.TabIndex = 11;
            blades.Text = "3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(6, 141);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(108, 15);
            label9.TabIndex = 10;
            label9.Text = "Swept Area (m^2): ";
            // 
            // sweptarea
            // 
            sweptarea.Location = new System.Drawing.Point(141, 138);
            sweptarea.Name = "sweptarea";
            sweptarea.Size = new System.Drawing.Size(108, 23);
            sweptarea.TabIndex = 9;
            sweptarea.Text = "6361.7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 112);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(115, 15);
            label6.TabIndex = 8;
            label6.Text = "Rotor Diameter (m): ";
            // 
            // rotord
            // 
            rotord.Location = new System.Drawing.Point(141, 109);
            rotord.Name = "rotord";
            rotord.Size = new System.Drawing.Size(108, 23);
            rotord.TabIndex = 7;
            rotord.Text = "90";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 83);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(107, 15);
            label7.TabIndex = 6;
            label7.Text = "Rated Power (kW): ";
            // 
            // power
            // 
            power.Location = new System.Drawing.Point(141, 80);
            power.Name = "power";
            power.Size = new System.Drawing.Size(108, 23);
            power.TabIndex = 5;
            power.Text = "2000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 54);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "Manufacturer: ";
            // 
            // manu
            // 
            manu.Location = new System.Drawing.Point(97, 51);
            manu.Name = "manu";
            manu.Size = new System.Drawing.Size(152, 23);
            manu.TabIndex = 3;
            manu.Text = "Vestas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 25);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 15);
            label4.TabIndex = 2;
            label4.Text = "Name:";
            // 
            // name
            // 
            name.Location = new System.Drawing.Point(97, 22);
            name.Name = "name";
            name.Size = new System.Drawing.Size(152, 23);
            name.TabIndex = 1;
            name.Text = "V90/2000";
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            button1.Location = new System.Drawing.Point(3, 362);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(248, 23);
            button1.TabIndex = 0;
            button1.Text = "Add Wind Power";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormGenArray
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(268, 422);
            Controls.Add(tabControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FormGenArray";
            Text = "New Energy Generation";
            groupBoxSolar.ResumeLayout(false);
            groupBoxSolar.PerformLayout();
            tabControl1.ResumeLayout(false);
            Solar.ResumeLayout(false);
            Wind.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Solar;
        private System.Windows.Forms.TabPage Wind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox blades;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sweptarea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rotord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox power;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox manu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cutoutspeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ratedspeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cutin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxHours;
    }
}