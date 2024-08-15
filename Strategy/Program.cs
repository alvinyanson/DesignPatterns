namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code picks a concrete strategy and passes it to the context. 
            // The client should be aware of the differences between strategies in order to make the right choice.
            //Create an instance of ZipCompression Strategy
            ICompression strategy = new ZipCompression();
            
            //Pass ZipCompression Strategy as an argument to the CompressionContext constructor
            CompressionContext ctx = new CompressionContext(strategy);
            ctx.CreateArchive("DotNetDesignPattern");
            
            //Changing the Strategy using SetStrategy Method
            ctx.SetStrategy(new RarCompression());
            ctx.CreateArchive("DotNetDesignPattern");
            
            Console.Read();
        }
    }
}