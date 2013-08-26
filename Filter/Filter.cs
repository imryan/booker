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
            
            roomSelector.Items.Add("Conference Room");
            roomSelector.Items.Add("Upstairs Conference Room");
            roomSelector.Items.Add("Sales Demo Unit 1");
            roomSelector.Items.Add("Sales Demo Unit 2");
            roomSelector.Items.Add("Other");

            typeSelector.Items.Add("Room/Item");
            typeSelector.Items.Add("Date");
            typeSelector.Items.Add("Time");
            typeSelector.Items.Add("Person");
             
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
            string room = roomSelector.SelectedIndex.ToString();
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
            if (typeSelector.SelectedItem.ToString() == "Room")
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
                int count = Program.booker.listView.Items.Count;
                string users = null;
                ListViewItem currentItem = null;

                for (int i = 0; i < count; i++)
                {
                    currentItem = Program.booker.listView.Items[i];

                    users = currentItem.SubItems[3].ToString();
                    users = users.Remove(0, 18);
                    users = users.Remove(users.Length - 1);

                    personPicker.Items.Add(users);
                }

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
