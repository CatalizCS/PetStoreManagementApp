using PetStoreManagementApp.Auths;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStoreManagementApp.Dialogs
{
    public partial class form_SignUp : Form
    {
        public form_SignUp()
        {
            InitializeComponent();
        }

        private void button_Continue_Click(object sender, EventArgs e)
        {
            /*panel_SignUp.Show();
            panel_Project.Width = panel_Project.MinimumSize.Width;
            //panel_proJect_Continue.Width = panel_proJect_Continue.MaximumSize.Width;
            ExpandPanelToLeft();
            panel_Continue.Hide();*/
            timer_Continue.Start();
        }
        private void ExpandPanelToLeft()
        {
            // Calculate the new width of the panel
            int newWidth = panel_proJect_Continue.MaximumSize.Width;

            // Calculate the new X position of the panel
            int newX = Math.Abs(this.Width - (2 * newWidth));

            // Update the panel's size and location
            panel_proJect_Continue.Size = new Size(newWidth, panel_proJect_Continue.MaximumSize.Height);
            panel_proJect_Continue.Location = new Point(newX - 40, panel_proJect_Continue.Location.Y);
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            /*panel_Project.Width = panel_Project.MaximumSize.Width;
            panel_proJect_Continue.Width = panel_proJect_Continue.MinimumSize.Width;
            panel_proJect_Continue.Location = new Point(308, 0);
            panel_SignUp.Hide();
            panel_Continue.Show();*/
            timer_SignUp.Start();
        }

        private void label_Signin_Click(object sender, EventArgs e)
        {
            form_Login form_Login = new form_Login();
            form_Login.Show();
            this.Hide();
        }

        private void form_SignUp_Load(object sender, EventArgs e)
        {
            panel_Project.Width = panel_Project.MaximumSize.Width;
            panel_proJect_Continue.Width = panel_proJect_Continue.MinimumSize.Width;
        }
        private bool isSlideContinueOpen = true;
        private bool isSlideSignupOpen = true;
        private void timer_SignUp_Tick(object sender, EventArgs e)
        {
            if (isSlideSignupOpen)
            {
                // Slide the panels to the left

                panel_Project.Width += 100;
                panel_SignUp.Width -= 100;
                panel_Continue.Width += 100;
                panel_proJect_Continue.Width -= 100;
                panel_proJect_Continue.Location = new Point(307, 0);
                if (panel_SignUp.Width == panel_SignUp.MinimumSize.Width)
                {
                    timer_SignUp.Stop();
                    this.Refresh();
                }
                if (panel_proJect_Continue.Width == panel_proJect_Continue.MinimumSize.Width)
                {
                    timer_SignUp.Stop();
                    this.Refresh();
                }
            }
            else
            {
                // Slide the panels to the right

                panel_Project.Width -= 100;
                panel_SignUp.Width += 100;
                panel_Continue.Width -= 100;

                if (panel_Project.Width == panel_Project.MaximumSize.Width)
                {
                    timer_SignUp.Stop();
                    this.Refresh();
                    isSlideSignupOpen = true;
                }

                if (panel_Continue.Width == panel_Continue.MaximumSize.Width)
                {
                    timer_SignUp.Stop();
                    this.Refresh();
                }
            }
        }

        private void timer_Continue_Tick(object sender, EventArgs e)
        {
            if (isSlideContinueOpen)
            {
                // Slide the panels to the left

                panel_Project.Width -= 100;
                panel_SignUp.Width += 100;
                panel_Continue.Width -= 100;
                ExpandPanelToLeft();

                if (panel_Project.Width == panel_Project.MinimumSize.Width)
                {
                    timer_Continue.Stop();
                    this.Refresh();
                }
                if (panel_Continue.Width == panel_Continue.MinimumSize.Width)
                {
                    timer_Continue.Stop();
                    this.Refresh();
                }
            }
            else
            {
                // Slide the panels to the right

                panel_Project.Width += 100;
                panel_SignUp.Width -= 100;
                panel_Continue.Width += 100;
                if (panel_SignUp.Width == panel_SignUp.MaximumSize.Width)
                {
                    timer_Continue.Stop();
                    this.Refresh();
                    isSlideContinueOpen = true;
                }

                if (panel_proJect_Continue.Width == panel_proJect_Continue.MaximumSize.Width)
                {
                    timer_Continue.Stop();
                    this.Refresh();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            form_Login form_Login = new form_Login();
            form_Login.Show();
            this.Hide();
        }

        private void button_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory and filter for image files
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Retrieve the selected file path
                string imagePath = openFileDialog.FileName;

                // Use the imagePath as needed (e.g., store it in a variable, display it in a text box, etc.)
                textBox_Pass.Text = imagePath;
            }
        }
    }
}
