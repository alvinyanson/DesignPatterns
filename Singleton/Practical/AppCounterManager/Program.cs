namespace AppCounterManager
{
    class Program
    {
        public static void Main(string[] args)
        {

            Parallel.For(0, 10, i =>
            {
                AppCounterManager.Instance.IncrementCounter("UserLogins");
            });


            long currentLogins = AppCounterManager.Instance.GetCounterValue("UserLogins");
         
            
            Console.WriteLine($"Current logins: {currentLogins}");
        }
    }
}