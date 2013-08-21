using System;
using System.Windows.Forms;
using Parse;

namespace Booker
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            ParseClient.Initialize("JIn62aA3iMD5IReUkuRx5Q4tGXQC6nfiVfrqKJBT", "GO9h3Apu14nh6aRyYYxGfMUANwyDtYQ4mm9wgQMO");
            ParseAnalytics.TrackAppOpenedAsync();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (ParseUser.CurrentUser != null)
            {
                MessageBox.Show(ParseUser.CurrentUser.Username + " is still logged in. Click to log back in.","Alert");

                usernameLogin.Enabled = false;
                passwordLogin.Enabled = false;
                forgotPassword.Enabled = false;
            }
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            if (usernameCreate.Text == "" || passwordCreate.Text == "")
            {
                MessageBox.Show("Please enter in all fields.", "Alert");
            }
            else
            {
                string username = usernameCreate.Text + "@mcroberts1876.com";

                    var user = new ParseUser()
                    {
                        Username = username,
                        Password = passwordCreate.Text
                    };

                    try
                    {
                        registerButton.Enabled = false;
                        await user.SignUpAsync();
                        MessageBox.Show("User sucessfully created.", "Alert");

                        // Login the new user
                        await ParseUser.LogInAsync(username, passwordCreate.Text);
                        MessageBox.Show("Successfully logged in.", "Alert");

                        Hide();
                        Program.booker = new Booker();
                        Program.booker.Show();
                    }
                    catch (Exception r)
                    {
                        Console.WriteLine(r.Message);

                        MessageBox.Show("Username already in use!", "Alert");
                        registerButton.Enabled = true;
                    }
                }
            }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            if (ParseUser.CurrentUser != null)
            {
                Hide();
                Program.booker = new Booker();
                Program.booker.Show();
            }

            if (ParseUser.CurrentUser == null)
            {
                usernameLogin.Enabled = true;
                passwordLogin.Enabled = true;
                forgotPassword.Enabled = true;

                if (usernameLogin.Text == "" || passwordLogin.Text == "")
                {
                    MessageBox.Show("Please enter in all fields.", "Alert");
                }
                else
                {
                    try
                    {
                        string username = usernameLogin.Text + "@mcroberts1876.com";

                        connectButton.Enabled = false;
                        await ParseUser.LogInAsync(username, passwordLogin.Text);
                        MessageBox.Show("Successfully logged in.", "Alert");

                        Hide();

                        Program.booker = new Booker();
                        Program.booker.Show();
                    }
                    catch (Exception l)
                    {
                        Console.WriteLine(l.Message);

                        MessageBox.Show("Invalid credentials, try again.", "Alert");
                        connectButton.Enabled = true;
                    }
                }
            }
        }
        
        private async void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = Microsoft.VisualBasic.Interaction.InputBox("Please enter the company email address\nyou used to register with.", "Alert","", -1, -1);

            if (email.Equals(""))
            {
                MessageBox.Show("Please enter in the email field and try again.", "Alert");
            }
            else if (!email.Contains("@mcroberts1876.com"))
            {
                MessageBox.Show("Please enter your company email address and try again.", "Alert");
            }
            else
            {
                await ParseUser.RequestPasswordResetAsync(email);
                MessageBox.Show("Password reset instructions sent to: " + email + "." + "Alert");
            }
        }
    }
}
