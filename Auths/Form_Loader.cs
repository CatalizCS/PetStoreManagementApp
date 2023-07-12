using PetStoreManagementApp.Auths;
using PetStoreManagementApp.Libs;
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

namespace PetStoreManagementApp.Dialogs
{
    public partial class Form_Loader : Form
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
        public bool loaded = false;
        public Form_Loader()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            // loading animation
            loadingBar.Value = 0;

            // load file config.cfg to get database connection string and save it to global variable
        }

        private async void Form_Loader_Load(object sender, EventArgs e)
        {
            ConfigReader configReader = new ConfigReader("config.cfg");

            if (configReader.validateConfig())
            {
                configReader.ReadConfig();
                await Task.Delay(1000);

                loadingBar.Value = 50;
                await Task.Delay(1000);

                // check database connection
                if (DatabaseConnection.Instance.IsConnected())
                {
                    loadingBar.Value = 70;
                    await Task.Delay(1000);
                    this.Hide();
                    loaded = true;
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

                // output all table name in database to console
                DatabaseConnection.Instance.test();

                new form_Login().Show();
            }
            else
            {
                MessageBox.Show("Không thể đọc file cấu hình", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            // check version from github and compare with current version
            if (await VersionChecker.Instance.checkVersion())
            {
                MessageBox.Show("Đã có version mới!", "Update", MessageBoxButtons.OK);
            }
            loadingBar.Value = 100;

        }
    }
}
