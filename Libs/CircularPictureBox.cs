using System.Drawing.Drawing2D;

namespace PetStoreManagementApp
{
    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            Region oldRegion = pe.Graphics.Clip;
            pe.Graphics.Clip = new Region(graphicsPath);

            // Draw the image within the circular path
            pe.Graphics.DrawImage(Image, 0, 0);

            base.OnPaint(pe);
        }
    }
}