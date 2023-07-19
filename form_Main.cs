using PetStoreManagementApp.Auths;
using PetStoreManagementApp.Dialogs;
using PetStoreManagementApp.Libs.DTO;
using PetStoreManagementApp.Pages;
using System.Runtime.InteropServices;

namespace PetStoreManagementApp
{
    public partial class form_Main : Form
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

        public form_Main()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        // Start mouse grab event
        private Size? _mouseGrabOffset;

        private void headerBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseGrabOffset = new Size(e.Location);
            }
            base.OnMouseDown(e);
        }

        private void headerBar_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseGrabOffset = null;
            base.OnMouseUp(e);
        }

        private void headerBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseGrabOffset.HasValue)
            {
                Location = new Point(Location.X + e.X - _mouseGrabOffset.Value.Width, Location.Y + e.Y - _mouseGrabOffset.Value.Height);
            }
            base.OnMouseMove(e);
        }
        // End mouse grab event


        // Start slideBar components
        private bool isSlideBarOpen = true;
        private void slideBarTimer_Tick(object sender, EventArgs e)
        {
            if (isSlideBarOpen)
            {
                slideBar_Container.Width -= 10;

                menu_container.Width = menu_Button.MinimumSize.Width;
                menu_Button.Width = menu_Button.MinimumSize.Width;
                petManager_Button.Width = petManager_Button.MinimumSize.Width;
                service_Button.Width = service_Button.MinimumSize.Width;
                customer_Button.Width = customer_Button.MinimumSize.Width;
                wareHouse_Button.Width = wareHouse_Button.MinimumSize.Width;
                about_Button.Width = about_Button.MinimumSize.Width;
                setting_Button.Width = setting_Button.MinimumSize.Width;

                mainInterface.Width = mainInterface.Width + 10;
                mainInterface.Location = new Point(mainInterface.Location.X - 10, 41);

                closeApp_Button.Location = new Point(closeApp_Button.Location.X + 10, 3);
                logout_Button.Location = new Point(logout_Button.Location.X + 10, 3);
                darkmode_Button.Location = new Point(darkmode_Button.Location.X + 10, 3);
                notification_Button.Location = new Point(notification_Button.Location.X + 10, 3);


                if (slideBar_Container.Width == slideBar_Container.MinimumSize.Width)
                {
                    info_Container.Hide();
                    slideBarTimer.Stop();
                    isSlideBarOpen = false;
                    this.Refresh();
                }
            }
            else
            {
                slideBar_Container.Width += 10;
                menu_Button.Width = menu_Button.MaximumSize.Width;
                menu_container.Width = menu_Button.MaximumSize.Width;
                petManager_Button.Width = petManager_Button.MaximumSize.Width;
                service_Button.Width = service_Button.MaximumSize.Width;
                customer_Button.Width = customer_Button.MaximumSize.Width;
                wareHouse_Button.Width = wareHouse_Button.MaximumSize.Width;
                about_Button.Width = about_Button.MaximumSize.Width;
                setting_Button.Width = setting_Button.MaximumSize.Width;

                mainInterface.Width = mainInterface.Width - 10;
                mainInterface.Location = new Point(mainInterface.Location.X + 10, 41);

                closeApp_Button.Location = new Point(closeApp_Button.Location.X - 10, 3);
                logout_Button.Location = new Point(logout_Button.Location.X - 10, 3);
                darkmode_Button.Location = new Point(darkmode_Button.Location.X - 10, 3);
                notification_Button.Location = new Point(notification_Button.Location.X - 10, 3);


                if (slideBar_Container.Width == slideBar_Container.MaximumSize.Width)
                {
                    info_Container.Show();
                    slideBarTimer.Stop();
                    isSlideBarOpen = true;
                    this.Refresh();
                }
            }
        }
        private void menu_Button_Click(object sender, EventArgs e)
        {
            slideBarTimer.Start();
        }

        // End slideBar components

        // Start button features

        private void closeApp_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // End button features


        // Loading form
        private void form_Main_Load(object sender, EventArgs e)
        {
            username.Text = DTO_UserInfo.Instance.LastName + " " + DTO_UserInfo.Instance.FirstName;
            switch (DTO_LoginData.Instance.permission)
            {
                case Permission.admin:
                    permission.Text = "Admin";
                    break;
                default:
                    permission.Text = "Employee";
                    break;
            }

            if (DTO_UserInfo.Instance.AvatarURL != "")
            {
                if (Form_Loader.avatarPath.findFile(Form_Loader.avatarPath.subName, DTO_UserInfo.Instance.AvatarURL) != null)
                    avatar_Image.Image = Image.FromFile(Path.Combine(Form_Loader.avatarPath.fullPath, DTO_UserInfo.Instance.AvatarURL));
            }
            else
            {
                avatar_Image.Image = Properties.Resources.user_24px;
            }

            this.petManager_Button_Click(sender, e);
        }

        private void logout_Button_Click(object sender, EventArgs e)
        {
            DTO_UserInfo.Instance.logout();
            DTO_LoginData.Instance.logout();
            this.Hide();

            new form_Login().Show();
        }


        private bool isDarkMode = false;
        private void darkMode_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
            {

            }
            else
            {

            }
        }

        // menu button
        private void petManager_Button_Click(object sender, EventArgs e)
        {
            // import form into panel
            containerName.Text = "Pet Manager";
            mainInterface.Controls.Clear();
            form_PetManager petManager = new form_PetManager();
            petManager.TopLevel = false;
            mainInterface.Controls.Add(petManager);
            petManager.Show();

        }

        private void service_Button_Click(object sender, EventArgs e)
        {
            containerName.Text = "Service Manager";
            mainInterface.Controls.Clear();
            form_Service serviceManager = new form_Service();
            serviceManager.TopLevel = false;
            mainInterface.Controls.Add(serviceManager);
            serviceManager.Show();
        }

        private void customer_Button_Click(object sender, EventArgs e)
        {
            containerName.Text = "Customer Manager";
            mainInterface.Controls.Clear();
            form_Customer customerManager = new form_Customer();
            customerManager.TopLevel = false;
            mainInterface.Controls.Add(customerManager);
            customerManager.Show();
        }

        private void wareHouse_Button_Click(object sender, EventArgs e)
        {
            containerName.Text = "WareHouse Manager";
            mainInterface.Controls.Clear();
            form_WareHouse wareHouseManager = new form_WareHouse();
            wareHouseManager.TopLevel = false;
            mainInterface.Controls.Add(wareHouseManager);
            wareHouseManager.Show();
        }

        private void about_Button_Click(object sender, EventArgs e)
        {
            containerName.Text = "About";
            mainInterface.Controls.Clear();
            form_About about = new form_About();
            about.TopLevel = false;
            mainInterface.Controls.Add(about);
            about.Show();
        }

        private void setting_Button_Click(object sender, EventArgs e)
        {
            mainInterface.Controls.Clear();
            if (DTO_LoginData.Instance.permission == Permission.employee)
            {
                containerName.Text = "Employee Settings";
                form_Employee settings = new form_Employee();
                settings.TopLevel = false;
                mainInterface.Controls.Add(settings);
                settings.Show();

            }
            else
            {
                containerName.Text = "Admin Settings";
                form_Admin settings = new form_Admin();
                settings.TopLevel = false;
                mainInterface.Controls.Add(settings);
                settings.Show();
            }
        }
    }
}