using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace ThumbScanner.WinUI
{
    public static class ImageUtitlity
    {
        public static byte[] ImageToBinary(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public static Image BinaryToImage(byte[] buffer)
        {
            if (buffer == null || buffer.Length == 0) return null;
            MemoryStream memStream = new MemoryStream();
            memStream.Write(buffer, 0, buffer.Length);
            return Image.FromStream(memStream);
        }
    }
}
