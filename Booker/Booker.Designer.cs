namespace Booker
{
    partial class Booker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booker));
            this.listView = new System.Windows.Forms.ListView();
            this.roomHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.contactButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roomHeader,
            this.dateHeader,
            this.timeHeader,
            this.personHeader});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.Location = new System.Drawing.Point(12, 27);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(660, 382);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // roomHeader
            // 
            this.roomHeader.Text = "Room";
            this.roomHeader.Width = 150;
            // 
            // dateHeader
            // 
            this.dateHeader.Text = "Date";
            this.dateHeader.Width = 150;
            // 
            // timeHeader
            // 
            this.timeHeader.Text = "Time";
            this.timeHeader.Width = 150;
            // 
            // personHeader
            // 
            this.personHeader.Text = "Person";
            this.personHeader.Width = 143;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBooking,
            this.deleteBooking,
            this.aboutButton,
            this.contactButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newBooking
            // 
            this.newBooking.Name = "newBooking";
            this.newBooking.Size = new System.Drawing.Size(90, 20);
            this.newBooking.Text = "New Booking";
            // 
            // deleteBooking
            // 
            this.deleteBooking.Name = "deleteBooking";
            this.deleteBooking.Size = new System.Drawing.Size(99, 20);
            this.deleteBooking.Text = "Delete Booking";
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(52, 20);
            this.aboutButton.Text = "About";
            // 
            // contactButton
            // 
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(61, 20);
            this.contactButton.Text = "Contact";
            this.contactButton.Click += new System.EventHandler(this.contactButton_Click);
            // 
            // Booker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 421);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Booker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booker";
            this.Load += new System.EventHandler(this.Booker_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader roomHeader;
        private System.Windows.Forms.ColumnHeader dateHeader;
        private System.Windows.Forms.ColumnHeader timeHeader;
        private System.Windows.Forms.ColumnHeader personHeader;
        public System.Windows.Forms.ListView listView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newBooking;
        private System.Windows.Forms.ToolStripMenuItem deleteBooking;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.ToolStripMenuItem contactButton;

    }
}