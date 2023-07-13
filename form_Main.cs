using System.Runtime.InteropServices;
using PetStoreManagementApp.Auths;
using System.Windows.Forms;
using PetStoreManagementApp.Dialogs;
using PetStoreManagementApp.Libs.DTO;

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
                mainInterface.Location = new System.Drawing.Point(mainInterface.Location.X - 10, 41);

                closeApp_Button.Location = new System.Drawing.Point(closeApp_Button.Location.X + 10, 3);
                logout_Button.Location = new System.Drawing.Point(logout_Button.Location.X + 10, 3);



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
                mainInterface.Location = new System.Drawing.Point(mainInterface.Location.X + 10, 41);

                closeApp_Button.Location = new System.Drawing.Point(closeApp_Button.Location.X - 10, 3);
                logout_Button.Location = new System.Drawing.Point(logout_Button.Location.X - 10, 3);


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
                case Permission.employee:
                    permission.Text = "Employee";
                    break;
                default:
                    permission.Text = "Customer";
                    break;
            }


            if (DTO_UserInfo.Instance.AvatarURL != "")
            {
                avatar_Image.Image = Image.FromFile(Path.Combine(DTO_UserInfo.Instance.AvatarURL));
            }
            else
            {
                avatar_Image.Image = Properties.Resources.user_24px;
            }
        }

        private void slideBar_Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logout_Button_Click(object sender, EventArgs e)
        {

        }
    }
}