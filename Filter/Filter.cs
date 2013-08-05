using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booker
{
    public partial class Filter : Form
    {
        public Filter()
        {
            InitializeComponent();
        }

        private void filterDate_Click(object sender, EventArgs e)
        {
            // Filter the list by date
            
            string date = datePicker.Value.ToShortDateString();
            int count = Program.booker.listView.Items.Count;
            ListViewItem searchItem = null;
            int index = 0;

            do
            {
                if (index < Program.booker.listView.Items.Count)
                {
                    // true = search subitems
                    // last false param = no partial matches (remove if you want partial matches)
                    searchItem = Program.booker.listView.FindItemWithText(date, true, index,false);
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

            Dispose();
        }

        private void filterTime_Click(object sender, EventArgs e)
        {
            // Filter the list by time

            string time = timePicker.Value.ToShortTimeString();
            int count = Program.booker.listView.Items.Count;
            ListViewItem searchItem = null;
            int index = 0;

            do
            {
                if (index < Program.booker.listView.Items.Count)
                {
                    // true = search subitems
                    // last false param = no partial matches (remove if you want partial matches)
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

            Dispose();
        }

        private void filterRoom_Click(object sender, EventArgs e)
        {
            // Filter the list by room

            string room = roomField.Text;
            int count = Program.booker.listView.Items.Count;
            ListViewItem searchItem = null;
            int index = 0;

            if (roomField.Text == "")
            {
                MessageBox.Show("Please enter a room.","Alert");
            }
            else
            {
                do
                {
                    if (index < Program.booker.listView.Items.Count)
                    {
                        // true = search subitems
                        // last false param = no partial matches (remove if you want partial matches)
                        searchItem = Program.booker.listView.FindItemWithText(room, true, index, false);
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

                Dispose();
            }
        }

        private void filterPerson_Click(object sender, EventArgs e)
        {
            // Filter by person

            string person = personField.Text.ToLower();
            int count = Program.booker.listView.Items.Count;
            ListViewItem searchItem = null;
            int index = 0;

            if (personField.Text == "")
            {
                MessageBox.Show("Please enter a person.","Alert");
            }
            else
            {
                do
                {
                    if (index < Program.booker.listView.Items.Count)
                    {
                        // true = search subitems
                        // last false param = no partial matches (remove if you want partial matches)
                        searchItem = Program.booker.listView.FindItemWithText(person, true, index, false);
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

                Dispose();
            }
        }
    }
}
