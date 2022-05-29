using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagMaster
{
    internal static class ImageFactory
    {
        public static byte[] ConvertImageToBytes(System.Drawing.Image file)
        {
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return imageBytes;
                //return Convert.ToBase64String(imageBytes);
            }
        }

        public static String ConvertImageToBase64(System.Drawing.Image file)
        {
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();                
                return Convert.ToBase64String(imageBytes);
            }
        }

        public static String ConvertImageToShortenedBase64(System.Drawing.Image file)
        {
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes).Substring(0,255);
            }
        }
    }
}
