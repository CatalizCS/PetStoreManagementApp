﻿using PetStoreManagementApp.Libs;
using PetStoreManagementApp.Libs.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStoreManagementApp.Auths
{
    public partial class form_Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public form_Login()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            username.Focus();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            // get username and password
            string usernameText = username.Text;
            string passwordText = password.Text;

            // check username and password empty or not validate
            if (usernameText == "" || passwordText == "")
            {
                MessageBox.Show("Please enter username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Text = "";
                username.Focus();
                return;
            }

            if (!RegexChecker.Instance.IsValidUsername(usernameText) || !RegexChecker.Instance.IsValidPassword(passwordText))
            {
                MessageBox.Show("Username or password is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Text = "";
                username.Focus();
                return;
            }

            try
            {
                string userID = DatabaseConnection.Instance.CheckLogin(usernameText, passwordText);
                DatabaseConnection.Instance.GetUserInfo(userID, DTO_LoginData.Instance.permission);

                form_Main mainForm = new form_Main();
                mainForm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Username or password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Text = "";
                username.Focus();
                return;
            }
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}