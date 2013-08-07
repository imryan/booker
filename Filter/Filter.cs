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
        private CheckBox[] _checkBoxes;
        private List<bool> filters;

        private bool dateSelected = false;
        private bool timeSelected = false;
        private bool roomSelected = false;
        private bool personSelected = false;

        public Filter()
        {
            InitializeComponent();

            roomField.Items.Add("Conference Room");
            roomField.Items.Add("Upstairs Conference Room");
            roomField.Items.Add("Other");

            _checkBoxes = new CheckBox[] { enableDate, enableTime, enableRoom, enablePerson };
        }

        private void showCheckedBoxes(object sender, EventArgs e)
        {
            for (int i = 0; i < _checkBoxes.Length; i++)
            {   
                // Determine the values of the booleans
                dateSelected = _checkBoxes[0].Checked   ? true : false;
                timeSelected = _checkBoxes[1].Checked   ? true : false;
                roomSelected = _checkBoxes[2].Checked   ? true : false;
                personSelected = _checkBoxes[3].Checked ? true : false;
            }

            filters = new List<bool>();

            // Check if the boolean is true; if so, add to filters
            addToFilters(dateSelected);
            addToFilters(timeSelected);
            addToFilters(roomSelected);
            addToFilters(personSelected);

            // FILTER THE LIST USING LINQ (HELP)
        }

        private void addToFilters(bool item)
        {
            if (item == true)
            {
                filters.Add(item);
            }
            else
            {
                return;
            }
        }

        private void filterDate(object sender, EventArgs e)
        {            
            string date = datePicker.Value.ToShortDateString();
            int count = Program.booker.listView.Items.Count;
            ListViewItem searchItem = null;
            int index = 0;

            do
            {
                if (index < Program.booker.listView.Items.Count)
                {
                    // True = search subitems
                    // Last false param = no partial matches (remove if you want partial matches)
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
                if (index < Program.booker.listView.Items.Count)
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

        private void filterRoom(object sender, EventArgs e)
        {
            string room = roomField.Text;
            int count = Program.booker.listView.Items.Count;
            ListViewItem searchItem = null;
            int index = 0;

            if (roomField.Text == "")
            {
                MessageBox.Show("Please enter a room.", "Alert");
            }
            else
            {
                do
                {
                    if (index < Program.booker.listView.Items.Count)
                    {
                        // True = search subitems
                        // Last false param = no partial matches (remove if you want partial matches)
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
                return;
            }
        }

        private void filterPerson(object sender, EventArgs e)
        {
            string person = personField.Text.ToLower();
            int count = Program.booker.listView.Items.Count;
            ListViewItem searchItem = null;
            int index = 0;

            if (personField.Text == "")
            {
                MessageBox.Show("Please enter a person.", "Alert");
            }
            else
            {
                do
                {
                    if (index < Program.booker.listView.Items.Count)
                    {
                        // True = search subitems
                        // Last false param = no partial matches (remove if you want partial matches)
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
                return;
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            showCheckedBoxes(sender, e);
        }
    }
}
