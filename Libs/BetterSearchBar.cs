using System.Drawing.Drawing2D;

namespace PetStoreManagementApp.Libs
{
    public class BetterSearchBar : TextBox
    {
        private GraphicsPath borderPath;
        private Pen borderPen;
        private Image searchIcon; // Load the search icon image and store it here

        public BetterSearchBar()
        {
            // Initialize the search icon image (replace "search_icon.png" with the actual icon file)
            searchIcon = Properties.Resources.search;

            // Remove the default padding
            this.Padding = new Padding(0);

            // Define the border pen
            borderPen = new Pen(this.ForeColor, 2);

            // Create the border path
            CreateBorderPath();

            // Handle the Resize event to update the border path and redraw the control
            this.Resize += (sender, e) => { CreateBorderPath(); this.Invalidate(); };
        }

        private void CreateBorderPath()
        {
            int borderRadius = Height / 2;
            borderPath = new GraphicsPath();
            borderPath.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90);
            borderPath.AddArc(Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90);
            borderPath.AddArc(Width - borderRadius * 2, Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
            borderPath.AddArc(0, Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
            borderPath.CloseFigure();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0F) // WM_PAINT
            {
                using (Graphics g = Graphics.FromHwnd(this.Handle))
                {
                    // Set high-quality rendering for smooth edges
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    // Draw the border
                    g.DrawPath(borderPen, borderPath);

                    // Calculate the position and size of the search icon
                    int iconSize = Height / 2 - 4;
                    int iconX = Width - Height + (Height - iconSize) / 2;
                    int iconY = (Height - iconSize) / 2;

                    // Draw the search icon image
                    g.DrawImage(searchIcon, new Rectangle(iconX, iconY, iconSize, iconSize));
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            // Dispose of the resources
            borderPen.Dispose();
            base.Dispose(disposing);
        }
    }
}