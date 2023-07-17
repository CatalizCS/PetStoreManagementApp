﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStoreManagementApp.Pages
{
    public partial class form_Settings : Form
    {
        public form_Settings()
        {
            InitializeComponent();
        }
        private string avatarURL = "";
        private void button_Change_Avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory and filter for image files
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Retrieve the selected file path
                string imagePath = openFileDialog.FileName;

                // Load the selected image into the pictureBox_Avatar control
                pictureBox_Avatar.Image = Image.FromFile(imagePath);
            }
            avatarURL = openFileDialog.FileName;
        }

        private void pictureBox_Avatar_Click(object sender, EventArgs e)
        {
            button_Change_Avatar_Click(sender, e);
        }

        private void clearTextbox()
        {
            textBox_FName.Clear();
            textBox_LName.Clear();
            textBox_Age.Clear();
            textBox_Phone.Clear();
            textBox_Email.Clear();
            textBox_Pass.Clear();
            textBox_Pass_Confirm.Clear();
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            clearTextbox();
            panel_Change.Show();
            panel_Profile.Hide();
            button_Delete.Visible = true;
        }

        private void form_Settings_Load(object sender, EventArgs e)
        {
            form_Main form_Main = new form_Main();
            panel_Change.Hide();
            pictureBox_Avatar.Image = form_Main.GetAvatarImage();
        }
        public void SetAvatarImage(Image image)
        {
            pictureBox_Avatar.Image = image;
        }
        private void button_Profile_Click(object sender, EventArgs e)
        {
            panel_Profile.Show();
            panel_Change.Hide();
            button_Profile.ForeColor = Color.White;
            button_Profile.BackColor = Color.DodgerBlue;
            button_Change.ForeColor = Color.DodgerBlue;
            button_Change.BackColor = Color.White;
            button_Delete.Visible = false;
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            clearTextbox();
            button_Profile_Click(sender, e);
        }

        private void button_Profile_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Profile.Show();
            panel_Change.Hide();
            button_Profile.ForeColor = Color.Black;
            button_Change.ForeColor = Color.DodgerBlue;
        }

        private void button_Change_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Change.Show();
            panel_Profile.Hide();
            button_Change.ForeColor = Color.Black;
            button_Profile.ForeColor = Color.DodgerBlue;
        }
    }
}
