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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.newBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.filterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.contactButton = new System.Windows.Forms.ToolStripMenuItem();
            this.featureRequestButton = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.loadingBox = new System.Windows.Forms.PictureBox();
            this.roomHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView = new System.Windows.Forms.ListView();
            this.versionLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBooking,
            this.deleteBooking,
            this.filterButton,
            this.moreToolStripMenuItem,
            this.logoutButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(722, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
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
            // filterButton
            // 
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(45, 20);
            this.filterButton.Text = "Filter";
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton,
            this.contactButton,
            this.featureRequestButton});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(158, 22);
            this.aboutButton.Text = "About";
            // 
            // contactButton
            // 
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(158, 22);
            this.contactButton.Text = "Contact";
            // 
            // featureRequestButton
            // 
            this.featureRequestButton.Name = "featureRequestButton";
            this.featureRequestButton.Size = new System.Drawing.Size(158, 22);
            this.featureRequestButton.Text = "Feature Request";
            this.featureRequestButton.Click += new System.EventHandler(this.featureRequestButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(57, 20);
            this.logoutButton.Text = "Logout";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // loadingBox
            // 
            this.loadingBox.Image = ((System.Drawing.Image)(resources.GetObject("loadingBox.Image")));
            this.loadingBox.Location = new System.Drawing.Point(308, 189);
            this.loadingBox.Name = "loadingBox";
            this.loadingBox.Size = new System.Drawing.Size(67, 66);
            this.loadingBox.TabIndex = 7;
            this.loadingBox.TabStop = false;
            // 
            // roomHeader
            // 
            this.roomHeader.Text = "Room";
            this.roomHeader.Width = 163;
            // 
            // dateHeader
            // 
            this.dateHeader.Text = "Date";
            this.dateHeader.Width = 163;
            // 
            // timeHeader
            // 
            this.timeHeader.Text = "Time";
            this.timeHeader.Width = 163;
            // 
            // personHeader
            // 
            this.personHeader.Text = "Person";
            this.personHeader.Width = 203;
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
            this.listView.Size = new System.Drawing.Size(698, 465);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.versionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.versionLabel.Location = new System.Drawing.Point(636, 7);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(74, 13);
            this.versionLabel.TabIndex = 8;
            this.versionLabel.Text = "Booker v1.0.3";
            // 
            // Booker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 504);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.loadingBox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Booker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booker";
            this.Load += new System.EventHandler(this.Booker_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem newBooking;
        private System.Windows.Forms.ToolStripMenuItem deleteBooking;
        private System.Windows.Forms.ToolStripMenuItem filterButton;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.ToolStripMenuItem contactButton;
        private System.Windows.Forms.ToolStripMenuItem featureRequestButton;
        private System.Windows.Forms.PictureBox loadingBox;
        private System.Windows.Forms.ColumnHeader roomHeader;
        private System.Windows.Forms.ColumnHeader dateHeader;
        private System.Windows.Forms.ColumnHeader timeHeader;
        private System.Windows.Forms.ColumnHeader personHeader;
        public System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ToolStripMenuItem logoutButton;
        private System.Windows.Forms.Label versionLabel;

    }
}