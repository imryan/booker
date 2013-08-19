﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.IsolatedStorage;
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
            usernameLogin.Focus();

            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly, null, null);
 
            // If it doesn't exist, ignore it
            if (!isoStore.FileExists("login.txt"))
            {
                MessageBox.Show("That file doesn't exist!");
            }

            // If it exists, read it in and trim the whitespaces
            else
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("login.txt", FileMode.Open, isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        string usernameFromFile = reader.ReadToEnd().Trim();
                        usernameLogin.Text = usernameFromFile;
                    }
                }
            }
                
            if (usernameLogin.Text != "")
            {
                rememberUsername.Checked = true;
                rememberUsername.Enabled = false;
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
                if (!usernameCreate.Text.Contains("@"))
                {
                    MessageBox.Show("Your username should be your company-issued email.", "Alert");
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
                        registerButton.Enabled = false;
                        await user.SignUpAsync();
                        MessageBox.Show("User sucessfully created.", "Alert");

                        // Login the new user
                        await ParseUser.LogInAsync(usernameCreate.Text, passwordCreate.Text);
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
                    Console.WriteLine(l.Message);

                    MessageBox.Show("Invalid credentials, try again.", "Alert");
                    connectButton.Enabled = true;
                }
            }
        }
        
        private void shouldRemember(object sender, EventArgs e)
        {
            if (rememberUsername.Checked)
            {
                IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly, null, null);
                
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("login.txt", FileMode.CreateNew, isoStore))
                {
                    // If the dir/file doesn't exist, create them now
                    if (!isoStore.DirectoryExists("Booker"))
                    {
                        isoStore.CreateDirectory("Booker");

                        if (!isoStore.FileExists("login.txt"))
                        {
                            isoStore.CreateFile("login.txt");
                        }
                    }

                    using (StreamWriter writer = new StreamWriter(isoStream))
                    {
                        string usernameToSave = usernameLogin.Text;
                        writer.WriteLine(usernameToSave);
                        MessageBox.Show("Login saved");
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
            else if (!email.Contains("@"))
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
