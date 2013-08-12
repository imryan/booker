namespace Booker
{
    partial class Filter
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
            this.enablePerson = new System.Windows.Forms.CheckBox();
            this.enableRoom = new System.Windows.Forms.CheckBox();
            this.enableTime = new System.Windows.Forms.CheckBox();
            this.enableDate = new System.Windows.Forms.CheckBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.roomField = new System.Windows.Forms.ComboBox();
            this.personField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enablePerson
            // 
            this.enablePerson.AutoSize = true;
            this.enablePerson.Location = new System.Drawing.Point(8, 164);
            this.enablePerson.Name = "enablePerson";
            this.enablePerson.Size = new System.Drawing.Size(15, 14);
            this.enablePerson.TabIndex = 47;
            this.enablePerson.UseVisualStyleBackColor = true;
            // 
            // enableRoom
            // 
            this.enableRoom.AutoSize = true;
            this.enableRoom.Location = new System.Drawing.Point(8, 122);
            this.enableRoom.Name = "enableRoom";
            this.enableRoom.Size = new System.Drawing.Size(15, 14);
            this.enableRoom.TabIndex = 46;
            this.enableRoom.UseVisualStyleBackColor = true;
            // 
            // enableTime
            // 
            this.enableTime.AutoSize = true;
            this.enableTime.Location = new System.Drawing.Point(8, 73);
            this.enableTime.Name = "enableTime";
            this.enableTime.Size = new System.Drawing.Size(15, 14);
            this.enableTime.TabIndex = 45;
            this.enableTime.UseVisualStyleBackColor = true;
            // 
            // enableDate
            // 
            this.enableDate.AutoSize = true;
            this.enableDate.Location = new System.Drawing.Point(8, 25);
            this.enableDate.Name = "enableDate";
            this.enableDate.Size = new System.Drawing.Size(15, 14);
            this.enableDate.TabIndex = 44;
            this.enableDate.UseVisualStyleBackColor = true;
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "h:mm tt";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(29, 68);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(194, 20);
            this.timePicker.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Filter by Time";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(28, 23);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(195, 20);
            this.datePicker.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Filter by Date";
            // 
            // roomField
            // 
            this.roomField.FormattingEnabled = true;
            this.roomField.Location = new System.Drawing.Point(28, 119);
            this.roomField.Name = "roomField";
            this.roomField.Size = new System.Drawing.Size(194, 21);
            this.roomField.TabIndex = 39;
            // 
            // personField
            // 
            this.personField.AcceptsTab = true;
            this.personField.Location = new System.Drawing.Point(28, 161);
            this.personField.Name = "personField";
            this.personField.Size = new System.Drawing.Size(195, 20);
            this.personField.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Filter by Person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Filter by Room";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(9, 191);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(212, 41);
            this.filterButton.TabIndex = 48;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 244);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.enablePerson);
            this.Controls.Add(this.enableRoom);
            this.Controls.Add(this.enableTime);
            this.Controls.Add(this.enableDate);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roomField);
            this.Controls.Add(this.personField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox enablePerson;
        private System.Windows.Forms.CheckBox enableRoom;
        private System.Windows.Forms.CheckBox enableTime;
        private System.Windows.Forms.CheckBox enableDate;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox roomField;
        private System.Windows.Forms.TextBox personField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button filterButton;


    }
}