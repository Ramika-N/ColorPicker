using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenColorPicker
{
    public static class ColorPickerHelper
    {
        public static Color GetColorAt(Point location)
        {
            using (Bitmap bitmap = new Bitmap(1, 1))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(location.X, location.Y, 0, 0, new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }
      
        public static Bitmap GetMagnifiedImage(Point location, int width, int height, int zoomFactor = 4)
        {
            int captureWidth = width / zoomFactor;
            int captureHeight = height / zoomFactor;
            int captureX = location.X - (captureWidth / 2);
            int captureY = location.Y - (captureHeight / 2);

            Bitmap result = new Bitmap(width, height);

            using (Bitmap capture = new Bitmap(captureWidth, captureHeight))
            {
                using (Graphics g = Graphics.FromImage(capture))
                {
                    g.CopyFromScreen(captureX, captureY, 0, 0, new Size(captureWidth, captureHeight));
                }

                using (Graphics g = Graphics.FromImage(result))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    g.DrawImage(capture, new Rectangle(0, 0, width, height));

                    using (Pen pen = new Pen(Color.Red, 1))
                    {
                        g.DrawLine(pen, width / 2, 0, width / 2, height);
                        g.DrawLine(pen, 0, height / 2, width, height / 2);
                    }
                }
            }

            return result;
        }

        // Color to HEX conversion helper
        public static string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}
