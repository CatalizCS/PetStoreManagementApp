using System;
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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void button_EmployeeMan_Click(object sender, EventArgs e)
        {
            Form_Setting_Admin form_Setting_Admin = new Form_Setting_Admin();
            form_Setting_Admin.Show();
            this.Hide();
            panel_Staff.Show();
            panel_Change.Hide();
            panel_Profile.Hide();
        }

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

        private void button_Delete_Click(object sender, EventArgs e)
        {
            clearTextbox();
            button_Profile_Click(sender, e);
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            clearTextbox();
            panel_Change.Show();
            panel_Profile.Hide();
            panel_Staff.Hide();
            button_Delete.Visible = true;
        }

        private void button_Profile_Click(object sender, EventArgs e)
        {
            panel_Profile.Show();
            panel_Change.Hide();
            panel_Staff.Hide();
        }

        private void button_Profile_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Profile.Show();
            panel_Change.Hide();
            panel_Staff.Hide();
        }

        private void button_Change_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Change.Show();
            panel_Profile.Hide();
            panel_Staff.Hide();
        }

        private void button_EmployeeMan_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Staff.Show();
            panel_Change.Hide();
            panel_Profile.Hide();
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            form_Main form_Main = new form_Main();
            pictureBox_Avatar.Image = form_Main.GetAvatarImage();
        }
    }
}
