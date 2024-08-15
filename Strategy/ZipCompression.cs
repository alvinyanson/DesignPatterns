
namespace Strategy
{
    // Concrete Strategy B
    // The following ZipCompression Concrete Strategy implement the Strategy Interface and 
    // Implement the CompressFolder Method. 
    public class ZipCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using zip approach: '" + compressedArchiveFileName
                 + ".zip' file is created");
        }
    }
}
