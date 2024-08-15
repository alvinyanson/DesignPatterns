namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Product with Out of Stock Status
            Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
            
            //User Alvin will be created and the user1 object will be registered to the subject
            Observer user1 = new Observer("Alvin");
            user1.AddSubscriber(RedMI);
           
            //User Alexa will be created and the user1 object will be registered to the subject
            Observer user2 = new Observer("Alexa");
            user2.AddSubscriber(RedMI);
           
            //User Alysa will be created and the user3 object will be registered to the subject
            Observer user3 = new Observer("Alysa");
            user3.AddSubscriber(RedMI);
            
            Console.WriteLine("Red MI Mobile current state : " + RedMI.GetAvailability());
            Console.WriteLine();
            
            user3.RemoveSubscriber(RedMI);
           
            // Now the product is available
            RedMI.SetAvailability("Available");
            Console.Read();
        }
    }
}