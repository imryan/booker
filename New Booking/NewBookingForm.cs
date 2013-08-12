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
        public newBookingForm()
        {
            InitializeComponent();

            roomField.Items.Add("Conference Room");
            roomField.Items.Add("Upstairs Conference Room");
            roomField.Items.Add("Other");
        }

        private async void newBookingButton_Click(object sender, EventArgs e)
        {
            /* 
             * Adds the row to the list
             * by sending params to the
             * handler method in the
             * next class, and adds to
             * the Parse database as well
             */

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
                Program.booker.UpdatingListView(array);

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