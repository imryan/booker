namespace Booker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.roomField = new System.Windows.Forms.ComboBox();
            this.untilDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newBookingButton
            // 
            this.newBookingButton.Location = new System.Drawing.Point(11, 252);
            this.newBookingButton.Name = "newBookingButton";
            this.newBookingButton.Size = new System.Drawing.Size(227, 33);
            this.newBookingButton.TabIndex = 9;
            this.newBookingButton.Text = "Add Booking";
            this.newBookingButton.UseVisualStyleBackColor = true;
            this.newBookingButton.Click += new System.EventHandler(this.newBookingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "&Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "&Start Time";
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "h:mm tt";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(12, 170);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(225, 20);
            this.startTimePicker.TabIndex = 17;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "h:mm tt";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(13, 215);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(224, 20);
            this.endTimePicker.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "&End Time";
            // 
            // roomField
            // 
            this.roomField.FormattingEnabled = true;
            this.roomField.Location = new System.Drawing.Point(12, 27);
            this.roomField.Name = "roomField";
            this.roomField.Size = new System.Drawing.Size(226, 21);
            this.roomField.TabIndex = 26;
            // 
            // untilDatePicker
            // 
            this.untilDatePicker.Location = new System.Drawing.Point(12, 122);
            this.untilDatePicker.Name = "untilDatePicker";
            this.untilDatePicker.Size = new System.Drawing.Size(225, 20);
            this.untilDatePicker.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "&To Date";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(13, 73);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(224, 20);
            this.fromDatePicker.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "&From Date";
            // 
            // newBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 297);
            this.Controls.Add(this.untilDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomField);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newBookingButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "newBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBookingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker startTimePicker;
        public System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox roomField;
        public System.Windows.Forms.DateTimePicker untilDatePicker;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label2;
    }
}