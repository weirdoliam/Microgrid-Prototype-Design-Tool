namespace WinFormsApp1
{
    partial class ChangeDateTime
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
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApplyJump = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonTomorrow = new System.Windows.Forms.Button();
            this.buttonYesterday = new System.Windows.Forms.Button();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.labelSunset = new System.Windows.Forms.Label();
            this.textBoxSunrise = new System.Windows.Forms.TextBox();
            this.textBoxSunset = new System.Windows.Forms.TextBox();
            this.buttonChangeSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMonth.Location = new System.Drawing.Point(110, 8);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(40, 28);
            this.labelMonth.TabIndex = 0;
            this.labelMonth.Text = "Jan";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDay.Location = new System.Drawing.Point(108, 33);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(43, 36);
            this.labelDay.TabIndex = 1;
            this.labelDay.Text = "30";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(72, 119);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(185, 23);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jump to: ";
            // 
            // buttonApplyJump
            // 
            this.buttonApplyJump.Location = new System.Drawing.Point(10, 148);
            this.buttonApplyJump.Name = "buttonApplyJump";
            this.buttonApplyJump.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyJump.TabIndex = 4;
            this.buttonApplyJump.Text = "Apply";
            this.buttonApplyJump.UseVisualStyleBackColor = true;
            this.buttonApplyJump.Click += new System.EventHandler(this.buttonApplyJump_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(182, 148);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonTomorrow
            // 
            this.buttonTomorrow.Location = new System.Drawing.Point(182, 12);
            this.buttonTomorrow.Name = "buttonTomorrow";
            this.buttonTomorrow.Size = new System.Drawing.Size(75, 23);
            this.buttonTomorrow.TabIndex = 6;
            this.buttonTomorrow.Text = "Tomorrow";
            this.buttonTomorrow.UseVisualStyleBackColor = true;
            this.buttonTomorrow.Click += new System.EventHandler(this.buttonTomorrow_Click);
            // 
            // buttonYesterday
            // 
            this.buttonYesterday.Location = new System.Drawing.Point(10, 12);
            this.buttonYesterday.Name = "buttonYesterday";
            this.buttonYesterday.Size = new System.Drawing.Size(75, 23);
            this.buttonYesterday.TabIndex = 7;
            this.buttonYesterday.Text = "Yesterday";
            this.buttonYesterday.UseVisualStyleBackColor = true;
            this.buttonYesterday.Click += new System.EventHandler(this.buttonYesterday_Click);
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.Location = new System.Drawing.Point(23, 41);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(51, 15);
            this.labelSunrise.TabIndex = 8;
            this.labelSunrise.Text = "Sunrise: ";
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.Location = new System.Drawing.Point(197, 41);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(48, 15);
            this.labelSunset.TabIndex = 9;
            this.labelSunset.Text = "Sunset: ";
            // 
            // textBoxSunrise
            // 
            this.textBoxSunrise.Location = new System.Drawing.Point(10, 59);
            this.textBoxSunrise.Name = "textBoxSunrise";
            this.textBoxSunrise.Size = new System.Drawing.Size(75, 23);
            this.textBoxSunrise.TabIndex = 10;
            // 
            // textBoxSunset
            // 
            this.textBoxSunset.Location = new System.Drawing.Point(182, 59);
            this.textBoxSunset.Name = "textBoxSunset";
            this.textBoxSunset.Size = new System.Drawing.Size(75, 23);
            this.textBoxSunset.TabIndex = 11;
            // 
            // buttonChangeSet
            // 
            this.buttonChangeSet.Location = new System.Drawing.Point(10, 88);
            this.buttonChangeSet.Name = "buttonChangeSet";
            this.buttonChangeSet.Size = new System.Drawing.Size(247, 23);
            this.buttonChangeSet.TabIndex = 12;
            this.buttonChangeSet.Text = "Change Sunrise and Sunset";
            this.buttonChangeSet.UseVisualStyleBackColor = true;
            this.buttonChangeSet.Click += new System.EventHandler(this.buttonChangeSet_Click);
            // 
            // ChangeDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(269, 181);
            this.Controls.Add(this.buttonChangeSet);
            this.Controls.Add(this.textBoxSunset);
            this.Controls.Add(this.textBoxSunrise);
            this.Controls.Add(this.labelSunset);
            this.Controls.Add(this.labelSunrise);
            this.Controls.Add(this.buttonYesterday);
            this.Controls.Add(this.buttonTomorrow);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonApplyJump);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelMonth);
            this.Name = "ChangeDateTime";
            this.Text = "Current Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApplyJump;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonTomorrow;
        private System.Windows.Forms.Button buttonYesterday;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.TextBox textBoxSunrise;
        private System.Windows.Forms.TextBox textBoxSunset;
        private System.Windows.Forms.Button buttonChangeSet;
    }
}