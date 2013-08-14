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
    public partial class newBookingForm : Form
    {
        public bool canAdd;

        public newBookingForm()
        {
            InitializeComponent();

            roomField.Items.Add("Conference Room");
            roomField.Items.Add("Upstairs Conference Room");
            roomField.Items.Add("Sales Demo Unit 1");
            roomField.Items.Add("Sales Demo Unit 2");
            roomField.Items.Add("Other");
        }

        private void checkIfExists(string[] array)
        {
            int count = Program.booker.listView.Items.Count;
            bool hasShown = false;
            canAdd = true;

            for (int i = 0; i < count; i++)
            {
                ListViewItem currentItem = Program.booker.listView.Items[i];
                if (currentItem.SubItems[1].ToString().Contains(array[1]) &&
                    currentItem.SubItems[0].ToString().Contains(array[0]) &&
                    currentItem.SubItems[2].ToString().Contains(array[2]) && !hasShown)
                {
                    MessageBox.Show("There is already a reservation for your selection.\nFor:\t" + array[0] + ".\nOn:\t" + array[1] + "." + "\nFrom:\t" + array[2] + ".", "Alert");
                    hasShown = true;
                    canAdd = false;
                }
            }
        }

        private async void newBookingButton_Click(object sender, EventArgs e)
        {
            if (roomField.Text == "")
            {
                MessageBox.Show("Fill in the fields left blank.", "Error");
            }
            else
            {
                string room = this.roomField.Text;
                string date = this.fromDatePicker.Value.ToShortDateString() + " - " + this.untilDatePicker.Value.ToShortDateString();
                string time = this.startTimePicker.Text + " - " + this.endTimePicker.Text;
                string person = ParseUser.CurrentUser.Username;

                string[] array = new string[4] { room, date, time, person };

                checkIfExists(array);

                if (canAdd)
                {
                    Program.booker.updatingListView(array);
                    Program.booker.getCurrentEvents(sender, e);

                    ParseObject booking = new ParseObject("Booking");
                    booking["room"] = room;
                    booking["date"] = date;
                    booking["time"] = time;
                    booking["person"] = person;
                    await booking.SaveAsync();

                    Dispose();
                }
            }
        }
    }
}