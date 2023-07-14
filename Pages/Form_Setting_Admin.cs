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
    public partial class Form_Setting_Admin : Form
    {
        public Form_Setting_Admin()
        {
            InitializeComponent();
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView_ListEm.Refresh();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            panel_Add.Show();
            panel_Delete.Hide();
            panel_Update.Hide();
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            panel_Add.Hide();
            panel_Delete.Hide();
            panel_Update.Show();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            panel_Add.Hide();
            panel_Delete.Show();
            panel_Update.Hide();
        }

        private void button_Add_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Add.Show();
            panel_Delete.Hide();
            panel_Update.Hide();
        }

        private void button_Change_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Add.Hide();
            panel_Delete.Hide();
            panel_Update.Show();
        }

        private void button_Delete_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Add.Hide();
            panel_Delete.Show();
            panel_Update.Hide();
        }

        private void Form_Setting_Admin_Load(object sender, EventArgs e)
        {
            form_Main form_Main = new form_Main();
            pictureBox_Avata_Em.Image = form_Main.GetAvatarImage();
        }
    }
}
