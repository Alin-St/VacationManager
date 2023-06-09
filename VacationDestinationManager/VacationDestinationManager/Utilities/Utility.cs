using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Text;

namespace VacationDestinationManager.Utilities
{
    internal class Utility
    {
        public static byte[] ImageToBytes(Image? image)
        {
            if (image is null)
                return Array.Empty<byte>();

            using var memoryStream = new MemoryStream();
            using var tempImage = new Bitmap(image);
            tempImage.Save(memoryStream, ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }

        /// <summary> Encodes the string using UTF8, then hashes it using SHA-256 and returns the resulting bytes. </summary>
        public static byte[] HashStringSha256(string s)
        {
            using var sha256 = SHA256.Create();
            var result = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
            return result;
        }
    }
}
