namespace WinFormsApp1.utilForms
{
    partial class ChangePriceOfPower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePriceOfPower));
            buttonSet = new System.Windows.Forms.Button();
            textBoxPrice = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // buttonSet
            // 
            buttonSet.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonSet.Location = new System.Drawing.Point(0, 322);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new System.Drawing.Size(311, 23);
            buttonSet.TabIndex = 0;
            buttonSet.Text = "Set";
            buttonSet.UseVisualStyleBackColor = true;
            buttonSet.Click += buttonSet_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxPrice.Location = new System.Drawing.Point(100, 12);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(199, 23);
            textBoxPrice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 15);
            label1.TabIndex = 2;
            label1.Text = "Power cost (c)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 49);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(203, 15);
            label2.TabIndex = 3;
            label2.Text = "Some general prices for NZ are listed:";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            richTextBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            richTextBox1.Location = new System.Drawing.Point(0, 70);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(311, 246);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // ChangePriceOfPower
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(311, 345);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPrice);
            Controls.Add(buttonSet);
            Name = "ChangePriceOfPower";
            Text = "Altar power price";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}