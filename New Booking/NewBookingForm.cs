using System;
using System.Windows.Forms;
using Parse;
using System.Collections.Generic;

namespace Booker
{
    public partial class newBookingForm : Form
    {
        public bool canAdd;

        public newBookingForm()
        {
            InitializeComponent();
            loadRoomsAndItems();
        }

        private async void loadRoomsAndItems()
        {
            var query = ParseObject.GetQuery("Items").OrderBy("date");
            IEnumerable<ParseObject> results = await query.FindAsync();

            foreach (var obj in results)
            {
                string name = obj.Get<string>("name");
                roomField.Items.Add(name);
            }
        }

        private void checkIfExists(string[] array)
        {
            int count = Program.booker.listView.Items.Count;
            string errorString = "There is already a reservation for your selection.\n\nFor:\t" + array[0] + ".\nOn:\t" + array[1] + "." + "\nFrom:\t" + array[2] + ".";
            bool hasShown = false;
            canAdd = true;

            for (int i = 0; i < count; i++)
            {
                ListViewItem currentItem = Program.booker.listView.Items[i];
                if (currentItem.SubItems[1].ToString().Contains(array[1]) &&
                    currentItem.SubItems[0].ToString().Contains(array[0]) &&
                    currentItem.SubItems[2].ToString().Contains(array[2]) && !hasShown)
                {
                    DialogResult dialogResult = MessageBox.Show(errorString + "\n\nAdd anyway?", "Alert", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        canAdd = true;
                    }
                    else
                    {
                        canAdd = false;
                    }

                    hasShown = true;
                }
                else if (currentItem.SubItems[0].ToString().Contains(array[0]) &&
                        currentItem.SubItems[1].ToString().Contains(array[1]) && !hasShown)
                {
                    DialogResult dialogResult = MessageBox.Show(errorString + "\n\nAdd anyway?", "Alert", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        canAdd = true;
                    }
                    else
                    {
                        canAdd = false;
                    }

                    hasShown = true;
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