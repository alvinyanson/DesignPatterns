namespace NoThreadSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the GetInstance static method to get the Singleton Instance
            NoThreadSafe fromTeachaer = NoThreadSafe.GetInstance();
            fromTeachaer.PrintDetails("From Teacher");
            
            //Call the GetInstance static method to get the Singleton Instance
            NoThreadSafe fromStudent = NoThreadSafe.GetInstance();
            fromStudent.PrintDetails("From Student");
            
            Console.ReadLine();
        }
    }

}