using PetStoreManagementApp.Libs.DTO;
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
    public partial class Ware_House : Form
    {
        public static DTO_LoginData loginData = new DTO_LoginData();
        private string permission;
        public Ware_House()
        {
            InitializeComponent();
        }
        private void openForm()
        {
            permission = loginData.permission.ToString();
        }
        private void Ware_House_Load(object sender, EventArgs e)
        {
            /*openForm();
            switch (permission)
            {
                case "Employee":
                    panel_data.Size = panel_data.MaximumSize;
                    panel_Controls.Visible = false;
                    dataGridView_Product.Size = dataGridView_Product.MaximumSize;
                    break;
                case "Admin":
                    panel_data.Size = panel_data.MinimumSize;
                    dataGridView_Product.Size = dataGridView_Product.MinimumSize;
                    panel_Controls.Visible = false;
                    break;
                case "customer":
                    panel_data.Size = panel_data.MaximumSize;
                    panel_Controls.Visible = false;
                    dataGridView_Product.Size = dataGridView_Product.MaximumSize;
                    break;
            }*/
            panel_data.Size = panel_data.MaximumSize;
            panel_Controls.Hide();
            dataGridView_Product.Size = dataGridView_Product.MaximumSize;
        }

        private void panel_NewOrder_Paint(object sender, PaintEventArgs e)
        {
            button_NewOrder_Click(sender, e);
        }

        private void button_NewOrder_Click(object sender, EventArgs e)
        {
            panel_data.Size = panel_data.MinimumSize;
            dataGridView_Product.Size = dataGridView_Product.MinimumSize;
            panel_Controls.Show();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            panel_Delete.Hide();
            panel_Update.Hide();
            panel_Add.Show();
            button_Add.ForeColor = Color.White;
            button_Add.BackColor = Color.DodgerBlue;
            button_Change.ForeColor = Color.DodgerBlue;
            button_Change.BackColor = Color.White;
            button_Delete.ForeColor = Color.DodgerBlue;
            button_Delete.BackColor = Color.White;
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            panel_Add.Hide();
            panel_Delete.Hide();
            panel_Update.Show();
            button_Add.ForeColor = Color.DodgerBlue;
            button_Add.BackColor = Color.White;
            button_Change.ForeColor = Color.White;
            button_Change.BackColor = Color.DodgerBlue;
            button_Delete.ForeColor = Color.DodgerBlue;
            button_Delete.BackColor = Color.White;

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            panel_Add.Hide();
            panel_Delete.Show();
            panel_Update.Hide();
            button_Add.ForeColor = Color.DodgerBlue;
            button_Add.BackColor = Color.White;
            button_Change.ForeColor = Color.DodgerBlue;
            button_Change.BackColor = Color.White;
            button_Delete.ForeColor = Color.White;
            button_Delete.BackColor = Color.DodgerBlue;
        }

        private void button_Add_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Delete.Hide();
            panel_Update.Hide();
            panel_Add.Show();
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

        private void panel_Controls_Click(object sender, EventArgs e)
        {
            button_Delete.ForeColor = Color.White;
            button_Delete.BackColor = Color.DodgerBlue;
            button_Change.ForeColor = Color.White;
            button_Change.BackColor = Color.DodgerBlue;
            button_Add.ForeColor = Color.White;
            button_Add.BackColor = Color.DodgerBlue;
        }
    }
}
