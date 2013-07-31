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

            /*
            ListViewItem searchItem = null;
            int index = 0;
            do
            {
                index = index == 0 ? 0 : Math.Min(Program.booker.listView.Items.Count - 1, index);
                searchItem = Program.booker.listView.FindItemWithText(date, true, index);
                if (searchItem != null)
                {
                    index = searchItem.Index + 1;

                    //rest of code
                }

            } while (searchItem != null);
             */
        }
    }
}
