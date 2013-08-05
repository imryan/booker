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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.filterPerson = new System.Windows.Forms.Button();
            this.personField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.filterRoom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.filterTime = new System.Windows.Forms.Button();
            this.filterDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.roomField = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 220);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.roomField);
            this.tabPage1.Controls.Add(this.filterPerson);
            this.tabPage1.Controls.Add(this.personField);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.timePicker);
            this.tabPage1.Controls.Add(this.filterRoom);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.filterTime);
            this.tabPage1.Controls.Add(this.filterDate);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.datePicker);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(313, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(313, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // filterPerson
            // 
            this.filterPerson.Location = new System.Drawing.Point(209, 163);
            this.filterPerson.Name = "filterPerson";
            this.filterPerson.Size = new System.Drawing.Size(87, 20);
            this.filterPerson.TabIndex = 24;
            this.filterPerson.Text = "Filter";
            this.filterPerson.UseVisualStyleBackColor = true;
            // 
            // personField
            // 
            this.personField.AcceptsTab = true;
            this.personField.Location = new System.Drawing.Point(5, 163);
            this.personField.Name = "personField";
            this.personField.Size = new System.Drawing.Size(195, 20);
            this.personField.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Filter by Person";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "h:mm tt";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(6, 76);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(194, 20);
            this.timePicker.TabIndex = 21;
            // 
            // filterRoom
            // 
            this.filterRoom.Location = new System.Drawing.Point(210, 119);
            this.filterRoom.Name = "filterRoom";
            this.filterRoom.Size = new System.Drawing.Size(87, 20);
            this.filterRoom.TabIndex = 20;
            this.filterRoom.Text = "Filter";
            this.filterRoom.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Filter by Room";
            // 
            // filterTime
            // 
            this.filterTime.Location = new System.Drawing.Point(210, 73);
            this.filterTime.Name = "filterTime";
            this.filterTime.Size = new System.Drawing.Size(87, 20);
            this.filterTime.TabIndex = 17;
            this.filterTime.Text = "Filter";
            this.filterTime.UseVisualStyleBackColor = true;
            // 
            // filterDate
            // 
            this.filterDate.Location = new System.Drawing.Point(210, 25);
            this.filterDate.Name = "filterDate";
            this.filterDate.Size = new System.Drawing.Size(87, 20);
            this.filterDate.TabIndex = 16;
            this.filterDate.Text = "Filter";
            this.filterDate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filter by Time";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(6, 25);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(195, 20);
            this.datePicker.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter by Date";
            // 
            // roomField
            // 
            this.roomField.FormattingEnabled = true;
            this.roomField.Location = new System.Drawing.Point(10, 121);
            this.roomField.Name = "roomField";
            this.roomField.Size = new System.Drawing.Size(189, 21);
            this.roomField.TabIndex = 25;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 244);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button filterPerson;
        private System.Windows.Forms.TextBox personField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button filterRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button filterTime;
        private System.Windows.Forms.Button filterDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roomField;

    }
}