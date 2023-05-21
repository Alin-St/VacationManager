namespace VacationDestinationManager.Utilities
{
    internal class Utility
    {
        public static byte[] ImageToBytes(Image image)
        {
            using var memoryStream = new MemoryStream();
            image.Save(memoryStream, image.RawFormat);
            return memoryStream.ToArray();
        }
    }
}
