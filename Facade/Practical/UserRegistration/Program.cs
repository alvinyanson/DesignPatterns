namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {

            Customer customer = new Customer()
            {
                Name = "Alvin",
                Email = "alvin@test.com",
                MobileNumber = "1234567890",
                Address = "Philippines"
            };


            CustomerRegistration customerRegistration = new CustomerRegistration();
            customerRegistration.RegisterCustomer(customer);

            Console.ReadKey();
        }

    }

}