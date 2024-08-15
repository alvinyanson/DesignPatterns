
namespace Strategy
{
    // Concrete Strategy A
    // The following RarCompression Concrete Strategy implement the Strategy Interface and 
    // Implement the CompressFolder Method. 
    public class RarCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using Rar approach: '" + compressedArchiveFileName
                 + ".rar' file is created");
        }
    }
}
