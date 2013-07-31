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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = datePicker.Value.ToShortDateString();
            int count = Program.booker.listView.Items.Count;

            ListViewItem searchItem = null;
            int index = 0;
            do
            {
                if (index < Program.booker.listView.Items.Count)
                {
                    //true = search subitems
                    //last false param = no partial matches (remove if you want partial matches)
                    searchItem = Program.booker.listView.FindItemWithText(date, true, index, false);
                    if (searchItem != null)
                    {
                        index = searchItem.Index + 1;

                        Program.booker.listView.MultiSelect = true;
                        searchItem.Selected = true;
                    }
                }
                else
                    searchItem = null;

            } while (searchItem != null);
        }
    }
}
