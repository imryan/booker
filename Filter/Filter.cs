 using System;
using System.Collections.Generic;
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
            roomField.Items.Add("Sales Demo Unit 1");
            roomField.Items.Add("Sales Demo Unit 2");
            roomField.Items.Add("Other");

            _checkBoxes = new CheckBox[] { enableDate, enableTime, enableRoom, enablePerson };
        }

        private void showCheckedBoxes(object sender, EventArgs e)
        {
            for (int i = 0; i < _checkBoxes.Length; i++)
            {   
                // Determine the values of the booleans
                dateSelected   = _checkBoxes[0].Checked ? true : false;
                timeSelected   = _checkBoxes[1].Checked ? true : false;
                roomSelected   = _checkBoxes[2].Checked ? true : false;
                personSelected = _checkBoxes[3].Checked ? true : false;
            }

            filters = new List<bool>();

            // Check if the boolean is true; if so, add to filters
            addToFilters(dateSelected);
            addToFilters(timeSelected);
            addToFilters(roomSelected);
            addToFilters(personSelected);

            // Filter the list with the given options
            filterList(sender, e);
        }

        private void filterList(object sender, EventArgs e)
        {
            if (filters.Contains(dateSelected))
            {
                // Filter date
                // Query here from Parse
                // https://parse.com/docs/dotnet_guide#queries
            }
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
            string date = datePicker.Value.ToShortTimeString();
            int count = Program.booker.listView.Items.Count;
            ListViewItem searchItem = null;
            int index = 0;

            do
            {
                if (index < Program.booker.listView.Items.Count)
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
            showCheckedBoxes(sender, e);
        }
    }
}
