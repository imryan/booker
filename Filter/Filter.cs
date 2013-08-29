using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Parse;

namespace Booker
{
    public partial class Filter : Form
    {
        private int tag;

        public Filter()
        {
            InitializeComponent();
            loadRoomsAndItems();
            loadAllUsers();

            typeSelector.Items.Add("Room/Item");
            typeSelector.Items.Add("Date");
            typeSelector.Items.Add("Time");
            typeSelector.Items.Add("Person");
        }

        private async void loadRoomsAndItems()
        {
            var query = ParseObject.GetQuery("Items");
            IEnumerable<ParseObject> results = await query.FindAsync();

            foreach (var obj in results)
            {
                string name = obj.Get<string>("name");
                roomSelector.Items.Add(name);
            }
        }

        private async void loadAllUsers()
        {
            var query = ParseObject.GetQuery("Userdata");
            IEnumerable<ParseObject> results = await query.FindAsync();

            foreach (var obj in results)
            {
                string username = obj.Get<string>("username");
                personPicker.Items.Add(username);
            }
        }

        private void Filter_Load(object sender, EventArgs e)
        {
            roomSelector.Visible = false;
            datePicker.Visible = false;
            timePicker.Visible = false;
            personPicker.Visible = false;
        }

        private void filterRoom(object sender, EventArgs e)
        {
            string room = roomSelector.SelectedItem.ToString();
            int count = Program.booker.listView.Items.Count;
            ListViewItem searchItem = null;
            int index = 0;

            do
            {
                if (index < count)
                {
                    // True = search subitems
                    // Last false param = no partial matches (remove if you want partial matches)
                    searchItem = Program.booker.listView.FindItemWithText(room, true, index, true);
                    if (searchItem != null)
                    {
                        index = searchItem.Index + 1;
                        Program.booker.listView.MultiSelect = true;
                        searchItem.Selected = true;
                    }
                }
                else
                {
                    searchItem = null;
                }
            } while (searchItem != null);

            return;
        }

        private void filterTime(object sender, EventArgs e)
        {
            string time = timePicker.Value.ToShortTimeString();
            int count = Program.booker.listView.Items.Count;
            ListViewItem searchItem = null;
            int index = 0;

            do
            {
                if (index < count)
                {
                    // True = search subitems
                    // Last false param = no partial matches (remove if you want partial matches)
                    searchItem = Program.booker.listView.FindItemWithText(time, true, index, true);
                    if (searchItem != null)
                    {
                        index = searchItem.Index + 1;
                        Program.booker.listView.MultiSelect = true;
                        searchItem.Selected = true;
                    }
                }
                else
                {
                    searchItem = null;
                }
            } while (searchItem != null);

            return;
        }

        private void filterPerson(object sender, EventArgs e)
        {
            string person = personPicker.SelectedItem.ToString();
            int count = Program.booker.listView.Items.Count;
            ListViewItem searchItem = null;
            int index = 0;

            do
            {
                if (index < count)
                {
                    // True = search subitems
                    // Last false param = no partial matches (remove if you want partial matches)
                    searchItem = Program.booker.listView.FindItemWithText(person, true, index, true);
                    if (searchItem != null)
                    {
                        index = searchItem.Index + 1;
                        Program.booker.listView.MultiSelect = true;
                        searchItem.Selected = true;
                    }
                }
                else
                {
                    searchItem = null;
                }
            } while (searchItem != null);

            return;
        }

        private void filterDate(object sender, EventArgs e)
        {
            string date = datePicker.Value.ToShortDateString();
            int count = Program.booker.listView.Items.Count;
            ListViewItem searchItem = null;
            int index = 0;

            do
            {
                if (index < count)
                {
                    // True = search subitems
                    // Last false param = no partial matches (remove if you want partial matches)
                    searchItem = Program.booker.listView.FindItemWithText(date, true, index, true);
                    if (searchItem != null)
                    {
                        index = searchItem.Index + 1;
                        Program.booker.listView.MultiSelect = true;
                        searchItem.Selected = true;
                    }
                }
                else
                {
                    searchItem = null;
                }
            } while (searchItem != null);

            return;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            switch (tag)
            {
                case 0:
                    filterRoom(sender, e);
                    break;
                case 1:
                    filterDate(sender, e);
                    break;
                case 2:
                    filterTime(sender, e);
                    break;
                case 3:
                    filterPerson(sender, e);
                    break;
            }

            Dispose();
        }

        private void typeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeSelector.SelectedItem.ToString() == "Room/Item")
            {
                roomSelector.Visible = true;
                tag = 0;
            }
            else
            {
                roomSelector.Visible = false;
            }

            if (typeSelector.SelectedItem.ToString() == "Date")
            {
                datePicker.Visible = true;
                tag = 1;
            }
            else
            {
                datePicker.Visible = false;
            }

            if (typeSelector.SelectedItem.ToString() == "Time")
            {
                timePicker.Visible = true;
                tag = 2;
            }
            else
            {
                timePicker.Visible = false;
            }

            if (typeSelector.SelectedItem.ToString() == "Person")
            {
                personPicker.Visible = true;
                tag = 3;
            }
            else
            {
                personPicker.Visible = false;
            }
        }
    }
}
