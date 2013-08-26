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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filter));
            this.filterButton = new System.Windows.Forms.Button();
            this.typeSelector = new System.Windows.Forms.ComboBox();
            this.roomSelector = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.personPicker = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(10, 72);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(212, 41);
            this.filterButton.TabIndex = 48;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // typeSelector
            // 
            this.typeSelector.FormattingEnabled = true;
            this.typeSelector.Location = new System.Drawing.Point(9, 10);
            this.typeSelector.Name = "typeSelector";
            this.typeSelector.Size = new System.Drawing.Size(211, 21);
            this.typeSelector.TabIndex = 49;
            this.typeSelector.SelectedIndexChanged += new System.EventHandler(this.typeSelector_SelectedIndexChanged);
            // 
            // roomSelector
            // 
            this.roomSelector.FormattingEnabled = true;
            this.roomSelector.Location = new System.Drawing.Point(8, 37);
            this.roomSelector.Name = "roomSelector";
            this.roomSelector.Size = new System.Drawing.Size(213, 21);
            this.roomSelector.TabIndex = 50;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(10, 38);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(212, 20);
            this.datePicker.TabIndex = 51;
            // 
            // personPicker
            // 
            this.personPicker.FormattingEnabled = true;
            this.personPicker.Location = new System.Drawing.Point(9, 36);
            this.personPicker.Name = "personPicker";
            this.personPicker.Size = new System.Drawing.Size(213, 21);
            this.personPicker.TabIndex = 53;
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "h:mm tt";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(8, 37);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(214, 20);
            this.timePicker.TabIndex = 54;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 125);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.personPicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.roomSelector);
            this.Controls.Add(this.typeSelector);
            this.Controls.Add(this.filterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.Filter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.ComboBox typeSelector;
        private System.Windows.Forms.ComboBox roomSelector;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox personPicker;
        public System.Windows.Forms.DateTimePicker timePicker;


    }
}