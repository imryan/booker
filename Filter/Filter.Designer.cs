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
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.filterDate = new System.Windows.Forms.Button();
            this.filterTime = new System.Windows.Forms.Button();
            this.filterRoom = new System.Windows.Forms.Button();
            this.roomField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter by Date";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(15, 25);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(195, 20);
            this.datePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter by Time";
            // 
            // filterDate
            // 
            this.filterDate.Location = new System.Drawing.Point(219, 25);
            this.filterDate.Name = "filterDate";
            this.filterDate.Size = new System.Drawing.Size(87, 20);
            this.filterDate.TabIndex = 4;
            this.filterDate.Text = "Filter";
            this.filterDate.UseVisualStyleBackColor = true;
            this.filterDate.Click += new System.EventHandler(this.filterDate_Click);
            // 
            // filterTime
            // 
            this.filterTime.Location = new System.Drawing.Point(219, 73);
            this.filterTime.Name = "filterTime";
            this.filterTime.Size = new System.Drawing.Size(87, 20);
            this.filterTime.TabIndex = 5;
            this.filterTime.Text = "Filter";
            this.filterTime.UseVisualStyleBackColor = true;
            this.filterTime.Click += new System.EventHandler(this.filterTime_Click);
            // 
            // filterRoom
            // 
            this.filterRoom.Location = new System.Drawing.Point(219, 119);
            this.filterRoom.Name = "filterRoom";
            this.filterRoom.Size = new System.Drawing.Size(87, 20);
            this.filterRoom.TabIndex = 8;
            this.filterRoom.Text = "Filter";
            this.filterRoom.UseVisualStyleBackColor = true;
            this.filterRoom.Click += new System.EventHandler(this.filterRoom_Click);
            // 
            // roomField
            // 
            this.roomField.AcceptsTab = true;
            this.roomField.Location = new System.Drawing.Point(15, 119);
            this.roomField.Name = "roomField";
            this.roomField.Size = new System.Drawing.Size(195, 20);
            this.roomField.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter by Room";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "h:mm tt";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(15, 76);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(194, 20);
            this.timePicker.TabIndex = 9;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 312);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.filterRoom);
            this.Controls.Add(this.roomField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filterTime);
            this.Controls.Add(this.filterDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button filterDate;
        private System.Windows.Forms.Button filterTime;
        private System.Windows.Forms.Button filterRoom;
        private System.Windows.Forms.TextBox roomField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}