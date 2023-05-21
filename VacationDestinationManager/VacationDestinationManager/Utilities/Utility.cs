using System.Drawing.Imaging;

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
    }
}
