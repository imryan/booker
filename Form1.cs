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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            // Initialize Parse
            ParseClient.Initialize("JIn62aA3iMD5IReUkuRx5Q4tGXQC6nfiVfrqKJBT", "GO9h3Apu14nh6aRyYYxGfMUANwyDtYQ4mm9wgQMO");
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // When the main form is loaded
            usernameLogin.Focus();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            if (usernameCreate.Text == "" || passwordCreate.Text == "")
            {
                MessageBox.Show("Please enter in all fields.", "Alert");

            }
            else
            {

                var user = new ParseUser()
                {

                    Username = usernameCreate.Text,
                    Password = passwordCreate.Text

                };

                try
                {
                    await user.SignUpAsync();
                    MessageBox.Show("User sucessfully created.", "Alert");
                }
                catch (Exception r)
                {
                    MessageBox.Show("Username already in use!", "Alert");
                }
            }
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            if (usernameLogin.Text == "" || passwordLogin.Text == "")
            {
                MessageBox.Show("Please enter in all fields.", "Alert");
            }
            else
            {
                try
                {
                    connectButton.Enabled = false;
                    await ParseUser.LogInAsync(usernameLogin.Text, passwordLogin.Text);
                    MessageBox.Show("Successfully logged in.", "Alert");

                    Hide();

                    Program.booker = new Booker();
                    Program.booker.Show();

                }
                catch (Exception l)
                {
                    MessageBox.Show("Invalid credentials, try again.", "Alert");
                    connectButton.Enabled = true;
                }
            }
        }
    }
}
