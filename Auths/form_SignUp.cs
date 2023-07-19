using PetStoreManagementApp.Auths;
using PetStoreManagementApp.Libs;
using PetStoreManagementApp.Pages.Forms;
using System.Runtime.InteropServices;

namespace PetStoreManagementApp.Dialogs
{
    public partial class form_SignUp : Form
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

        public form_SignUp()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
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
                panel_proJect_Continue.Location = new Point(panel_proJect_Continue.MaximumSize.Width, 0);
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

        private void button_Continue_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == "")
            {
                new CustomMessageBox("Please enter your username!").ShowDialog();
                textBox_Username.Focus();
                return;
            }

            if (textBox_LastName.Text == "")
            {
                new CustomMessageBox("Please enter your password!").ShowDialog();
                textBox_Pass.Focus();
                return;
            }

            if (textBox_Age.Text == "")
            {
                new CustomMessageBox("Please enter your Age!").ShowDialog();
                textBox_Age.Focus();
                return;
            }
            else if (!RegexChecker.Instance.IsValidAge(textBox_Age.Text))
            {
                new CustomMessageBox("Age must be a number!").ShowDialog();
                textBox_Age.Focus();
                return;
            }
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
            timer_SignUp.Start();
        }

        private void label_Signin_Click(object sender, EventArgs e)
        {
            form_Login form_Login = new form_Login();
            form_Login.Show();
            this.Hide();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "")
            {
                new CustomMessageBox("Please enter your Email!").ShowDialog();
                textBox_Email.Focus();
                return;
            }
            else if (!RegexChecker.Instance.IsValidEmail(textBox_Email.Text))
            {
                new CustomMessageBox("Email is not valid!").ShowDialog();
                textBox_Email.Focus();
                return;
            }

            if (textBox_Username.Text == "")
            {
                new CustomMessageBox("Please enter your username!").ShowDialog();
                textBox_Username.Focus();
                return;
            }
            else if (!RegexChecker.Instance.IsValidUsername(textBox_Username.Text))
            {
                new CustomMessageBox("Username must be a number or string!").ShowDialog();
                textBox_Username.Focus();
                return;
            }

            if (textBox_Pass.Text == "")
            {
                new CustomMessageBox("Please enter your password!").ShowDialog();
                textBox_Pass.Focus();
                return;
            }
            else if (!RegexChecker.Instance.IsValidPassword(textBox_Pass.Text))
            {
                new CustomMessageBox("Password must be a number or string!").ShowDialog();
                textBox_Pass.Focus();
                return;
            }

            // Check if the user is already registered
            string query = "SELECT * FROM LoginData WHERE Username = '" + textBox_Username.Text.ToString() + "'";
            Console.WriteLine(DatabaseConnection.Instance.CheckExist(query));
            if (DatabaseConnection.Instance.CheckExist(query))
            {
                new CustomMessageBox("Username is already registered!").ShowDialog();
                textBox_Username.Focus();
                return;
            }

            // if the user is not registered, register the user
            query = "INSERT INTO LoginData (Username, Password) VALUES ('" + textBox_Username.Text.ToString() + "', '" + textBox_Pass.Text.ToString() + "')";
            if (DatabaseConnection.Instance.Execute(query))
            {
                // insert userinfo
                query = "INSERT INTO Employee_InfoData (FirstName, LastName, Age, Email) VALUES ('" + textBox_FirstName.Text.ToString() + "', '" + textBox_LastName.Text.ToString() + "', '" + textBox_Age.Text.ToString() + "', '" + textBox_Email.Text.ToString() + "')";
                if (DatabaseConnection.Instance.Execute(query))
                {
                    new CustomMessageBox("Registered successfully!").ShowDialog();
                    form_Login form_Login = new form_Login();
                    form_Login.Show();
                    this.Hide();
                }
                else
                {
                    new CustomMessageBox("Registered failed!").ShowDialog();
                }
            }
            else
            {
                new CustomMessageBox("Registered failed!").ShowDialog();
            }

        }
    }
}
