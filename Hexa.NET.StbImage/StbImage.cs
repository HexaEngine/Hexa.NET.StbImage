namespace Hexa.NET.StbImage
{
    public partial class StbImage
    {
        static StbImage()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            return "stbimage";
        }
    }
}
