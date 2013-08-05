using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Parse;

namespace Booker
{
    public partial class Booker : Form
    {
        delegate void MyDelegate(string[] array);

        public Booker()
        {
            InitializeComponent();

            newBooking.Click += new EventHandler(newBooking_Click);
            deleteBooking.Click += new EventHandler(deleteBooking_Click);
            aboutButton.Click += new EventHandler(aboutButton_Click);
            contactButton.Click += new EventHandler(contactButton_Click);
            refreshButton.Click += new EventHandler(refreshButton_Click);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            /* 
             * Overrides the form's
             * closing action(s)
             */

            ParseUser.LogOut();
            base.OnFormClosing(e);
            Environment.Exit(0);
        }

        private async void Booker_Load(object sender, EventArgs e)
        {
            /* 
             * Handles the form's
             * startup jobs to perform
             */

                loadingBox.Visible = true;

                listView.View = View.Details;
                listView.AllowColumnReorder = false;
                listView.MultiSelect = true;

                Font ft = new Font(listView.Font.Name, 10);
                listView.Font = ft;

                var query = ParseObject.GetQuery("Booking")
                                       .OrderBy("date");

                IEnumerable<ParseObject> results = await query.FindAsync();

                foreach (var obj in results)
                {
                    string room = obj.Get<string>("room");
                    string date = obj.Get<string>("date");
                    string time = obj.Get<string>("time");
                    string person = uppercaseFirst(obj.Get<string>("person"));

                    string[] array = new string[4] { room, date, time, person };
                    UpdatingListView(array);
            }

                loadingBox.Visible = false;
        }

        private static string uppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void newBooking_Click(object sender, EventArgs e)
        {
            /* 
             * Displays the dialog to
             * add a new booking
             */

            newBookingForm nbf = new newBookingForm();
            nbf.ShowDialog();
        }

        public void UpdatingListView(string[] array)
        {
            /* 
             * Handles the addition of
             * new rows being added to
             * the list
             */

            if (this.listView.InvokeRequired)
            {
                this.listView.Invoke(new MyDelegate(UpdatingListView), new object[] { array });

            } else {
                ListViewItem lvi = new ListViewItem(array[0]);
                lvi.SubItems.Add(array[1]);
                lvi.SubItems.Add(array[2]);
                lvi.SubItems.Add(array[3]);
                this.listView.Items.Add(lvi);
            }
        }

        private void deleteBooking_Click(object sender, EventArgs e)
        {
            /* 
             * Deletes the row from the list
             * and the Parse database
            
            var query = ParseObject.GetQuery("Booking")
                                   .OrderBy("date");

            IEnumerable<ParseObject> results = await query.FindAsync();
            

            foreach (ListViewItem item in listView.SelectedItems)
            {
                listView.Items.Remove(item);
            }
             */

            MessageBox.Show("Deleting items is still being developed. Contact Ryan for reservation removal.", "Alert");
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            /* 
             * Displays the application's
             * about panel
             */

            About about = new About();
            about.ShowDialog();
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            /* 
             * Open default mail client
             * to contact developer.
             */

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "mailto:notryancohen@gmail.com?subject=Booker";
            process.Start();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            filter.ShowDialog();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Booker_Load(sender, e);
        }
    }
}