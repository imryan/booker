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
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ParseUser.LogOut();
            base.OnFormClosing(e);
            Environment.Exit(0);
        }

        private async void Booker_Load(object sender, EventArgs e)
        {
                loadingBox.Visible = true;

                Font ft = new Font(listView.Font.Name, 10);
                listView.Font = ft;

                listView.View = View.Details;
                listView.AllowColumnReorder = false;
                listView.MultiSelect = true;

                var query = ParseObject.GetQuery("Booking")
                                       .OrderBy("date");

                IEnumerable<ParseObject> results = await query.FindAsync();

                foreach (var obj in results)
                {
                    string room = obj.Get<string>("room");
                    string date = obj.Get<string>("date");
                    string time = obj.Get<string>("time");
                    string person = obj.Get<string>("person");

                    string[] array = new string[4] { room, date, time, person };
                    updatingListView(array);
            }
                loadingBox.Visible = false;
                archiveReservation(sender, e);
                getCurrentEvents(sender, e);
        }

        private void newBooking_Click(object sender, EventArgs e)
        {
            newBookingForm nbf = new newBookingForm();
            nbf.ShowDialog();
        }

        public void getCurrentEvents(object sender, EventArgs e)
        {
            TimeSpan now = DateTime.Now.TimeOfDay;

            for (int i = 0; i < listView.Items.Count; i++)
            {
                ListViewItem currentItem = listView.Items[i];

                string startTime = currentItem.SubItems[2].ToString().Remove(0, 18);
                startTime = startTime.Remove(startTime.Length - 13);

                string endTime = currentItem.SubItems[2].ToString().Remove(0, 28);
                endTime = endTime.Remove(endTime.Length - 1);

                DateTime startDt = stringToDate(startTime);
                DateTime endDt = stringToDate(endTime);

                TimeSpan start = startDt.TimeOfDay;
                TimeSpan end = endDt.TimeOfDay;

                if (isBetweenTimes(DateTime.Now, start, end))
                {
                    currentItem.Font = new Font(currentItem.Font, FontStyle.Bold);
                }
            }
        }

        private bool isBetweenTimes(DateTime datetime, TimeSpan start, TimeSpan end)
        {
            TimeSpan now = datetime.TimeOfDay;

            if (start < end)
            {
                return start <= now && now <= end;
            }
            else
            {
                return !(end <= now && now <= start);
            }
        }

        public void updatingListView(string[] array)
        {
            if (this.listView.InvokeRequired)
            {
                this.listView.Invoke(new MyDelegate(updatingListView), new object[] { array });

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
            var query = ParseObject.GetQuery("Booking")
                                   .OrderBy("date");

            IEnumerable<ParseObject> results = await query.FindAsync();
             * 
            foreach (ListViewItem item in listView.SelectedItems)
            {
                listView.Items.Remove(item);
            }
            */

            MessageBox.Show("Item deletion is still being developed. Contact Ryan for reservation removal.", "Alert");
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "mailto:ryan.cohen@mcroberts1876.com?subject=Booker Reservation Deletion";
            process.Start();
        }

        private void archiveReservation(object sender, EventArgs e)
        {
            // Search for the current date in the LVIs
            DateTime currentDate = DateTime.UtcNow.Date;
            string date = currentDate.ToShortDateString();
            int count = listView.Items.Count;

            DateTime now = stringToDate(date);

            for (int i = 0; i < count; i++)
            {
                ListViewItem currentItem = listView.Items[i];
                string stringFromItem = currentItem.SubItems[1].ToString().Remove(0, 18);
                stringFromItem = stringFromItem.Remove(stringFromItem.Length - 12);
                DateTime then = stringToDate(stringFromItem);

                if (now > then)
                {
                    currentItem.ForeColor = Color.Gray;
                }
            }
        }

        private DateTime stringToDate(string date)
        {
            DateTime dt;
            DateTime.TryParse(date, out dt);
            return dt;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "mailto:ryan.cohen@mcroberts1876.com?subject=Booker Contact";
            process.Start();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            filter.ShowDialog();
        }

        private void featureRequestButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "mailto:ryan.cohen@mcroberts1876.com?subject=Booker Feature Request";
            process.Start();
        }
    }
}