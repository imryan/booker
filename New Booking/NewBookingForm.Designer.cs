﻿namespace Booker
{
    partial class newBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newBookingForm));
            this.newBookingButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomField = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.timeField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.personField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newBookingButton
            // 
            this.newBookingButton.Location = new System.Drawing.Point(10, 198);
            this.newBookingButton.Name = "newBookingButton";
            this.newBookingButton.Size = new System.Drawing.Size(227, 33);
            this.newBookingButton.TabIndex = 9;
            this.newBookingButton.Text = "Add Booking";
            this.newBookingButton.UseVisualStyleBackColor = true;
            this.newBookingButton.Click += new System.EventHandler(this.newBookingButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Room";
            // 
            // roomField
            // 
            this.roomField.AcceptsTab = true;
            this.roomField.Location = new System.Drawing.Point(12, 26);
            this.roomField.Name = "roomField";
            this.roomField.Size = new System.Drawing.Size(228, 20);
            this.roomField.TabIndex = 5;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(12, 163);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(226, 20);
            this.datePicker.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time";
            // 
            // timeField
            // 
            this.timeField.AcceptsTab = true;
            this.timeField.Location = new System.Drawing.Point(10, 70);
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(228, 20);
            this.timeField.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            // 
            // personField
            // 
            this.personField.AcceptsTab = true;
            this.personField.Location = new System.Drawing.Point(10, 118);
            this.personField.Name = "personField";
            this.personField.Size = new System.Drawing.Size(228, 20);
            this.personField.TabIndex = 13;
            // 
            // newBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 243);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.personField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeField);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.newBookingButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBookingButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox roomField;
        public System.Windows.Forms.DateTimePicker datePicker;
        public System.Windows.Forms.TextBox timeField;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox personField;
    }
}