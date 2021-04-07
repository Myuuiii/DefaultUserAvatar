using System;
using System.Drawing;

namespace DefaultUserAvatar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hi there
            // Thank you for checking out the code for a bit
            // Please let me know if there's anything that I should improve on
            // I'd love to learn more!
            //
            // ~ Myu

            // This will generate a base64 string, this is the encoded image that has been generated
            String Base64ImageString = DefaultAvatar.GenerateAvatar("Myu", "Developer");

            // This will generate an image and save the file to the given location
            DefaultAvatar.GenerateAvatar("Myu", "Developer", "./myu1.png");

            // This will generate an image with a custom background color (saved in folder)
            DefaultAvatar.GenerateAvatar("Myu", "Developer", "./myu2.png", Color.FromArgb(200, 10, 100));

            // This will generate an image with a custom background color and brush (saved in folder)
            DefaultAvatar.GenerateAvatar("Myu", "Developer", "./myu3.png", Color.White, Brushes.HotPink);
        }
    }
}
