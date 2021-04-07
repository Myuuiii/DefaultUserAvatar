using System;
using System.Drawing;

namespace DefaultUserAvatar
{
    public class DefaultAvatar
    {
        /// <summary>
        /// Generate a new avatar from the user's first an last name
        /// </summary>
        /// <param name="firstName">First name of the user</param>
        /// <param name="lastName">Last name of the user</param>
        /// <returns>Base64 string of the generated avatar</returns>
        public static String GenerateAvatar(String firstName, String lastName, String savePath = "", Color customBackgroundColor = new Color(), Brush customBrush = null)
        {
            Bitmap bmp = new Bitmap(256, 256);
            Graphics graphics = Graphics.FromImage(bmp);

            // Configures where on the screen the text will be drawn
            // In this rectangle the height has been modified so the text is correctly, vertically centered
            RectangleF textRange = new RectangleF(0, bmp.Height / 3 - 12, bmp.Width, bmp.Height);

            // The background color for the template image
            Color backgroundColor = Color.FromArgb(6, 39, 70);
            if (customBackgroundColor != new Color())
            {
                backgroundColor = customBackgroundColor;
            }

            // Draw the background
            for (int xAxis = 0; xAxis < bmp.Width; xAxis++)
            {
                for (int yAxis = 0; yAxis < bmp.Height; yAxis++)
                {
                    bmp.SetPixel(xAxis, yAxis, backgroundColor);
                }
            }

            // Extract the first character from first name and last name and put them together
            string initials = $"{firstName.ToCharArray()[0]}{lastName.ToCharArray()[0]}";

            // Draw the initials on the BMP and flush it to the BMP
            if (customBrush == null)
            {
                graphics.DrawString(initials.ToUpper(), new Font("Arial", 76), Brushes.White, textRange, new StringFormat() { Alignment = StringAlignment.Center });
            }
            else
            {
                graphics.DrawString(initials.ToUpper(), new Font("Arial", 76), customBrush, textRange, new StringFormat() { Alignment = StringAlignment.Center });
            }

            graphics.Flush();

            if (savePath != "")
            {
                try
                {
                    bmp.Save(savePath);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            // Return the image encoded to base64
            return Convert.ToBase64String((byte[])new ImageConverter().ConvertTo(bmp, typeof(byte[])));
        }
    }
}