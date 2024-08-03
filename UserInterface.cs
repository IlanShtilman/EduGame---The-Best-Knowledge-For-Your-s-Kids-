﻿using System;
using System.Windows.Forms;

namespace final_project
{
    public partial class UserInterface : Form
    {
        private User userActive;
        private Database database;

        public UserInterface(Database db, int userIndex)
        {
            InitializeComponent();
            database = db;
            LoadUser(userIndex);
            UpdateForm();
        }

        private void LoadUser(int userIndex)
        {
            this.userActive = database.LoadUserData(userIndex);
        }
        private void UpdateForm()
        {
            textBoxUserName.Text = this.userActive.Username;
            textBoxPassword.Text = this.userActive.Password;
            textBoxID.Text = this.userActive.ID;
            textBoxEmail.Text = this.userActive.Email;
            textBoxGender.Text = this.userActive.Gender;
            textBoxCoins.Text = this.userActive.Balance.ToString();
        }

        private void buttonChangeUserName_Click(object sender, EventArgs e)
        {
            ChangeUserName changeUserForm = new ChangeUserName(database, userActive);
            if (changeUserForm.ShowDialog() == DialogResult.OK)
            {
                UpdateForm();
            }
        }

        private void buttonCHangePassword_Click_1(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword(database, userActive);
            if (changePasswordForm.ShowDialog() == DialogResult.OK)
            {
                UpdateForm();
            }
        }
    }
}