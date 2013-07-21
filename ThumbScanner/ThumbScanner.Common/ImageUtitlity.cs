using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ThumbScanner.Common
{
   public static class ImageUtitlity
    {
       public static byte[] ImageToBinary(string imagePath)
       {
           FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
           byte[] buffer = new byte[fileStream.Length];
           fileStream.Read(buffer, 0, (int)fileStream.Length);
           fileStream.Close();
           return buffer;
       }
      
    }
}
