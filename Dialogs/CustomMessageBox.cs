using System.Runtime.InteropServices;

namespace PetStoreManagementApp.Pages.Forms
{
    public partial class CustomMessageBox : Form
    {
        private const int WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int WS_EX_NOACTIVATE = 0x08000000;
        private const int WS_EX_TOOLWINDOW = 0x00000080;
        private const int WS_EX_TOPMOST = 0x00000008;

        private const int WM_NCHITTEST = 0x0084;
        private const int HTTRANSPARENT = -1;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

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

        public CustomMessageBox(string message)
        {
            InitializeComponent();
            Message.Text = message;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            // Đặt Form luôn ở trên cùng
            this.TopMost = true;
        }

        // Xử lý việc kéo Form bằng tiêu đề (caption)
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && m.Result == (IntPtr)HTCLIENT)
            {
                m.Result = (IntPtr)HTCAPTION;
            }
        }

        private void betterButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
