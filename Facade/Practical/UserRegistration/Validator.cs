
namespace UserRegistration
{
    public class Validator
    {
        public bool ValidateCustomer(Customer customer)
        {
            Console.WriteLine("Customer Validated...");
            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"Email: {customer.Email}");
            Console.WriteLine($"Mobile: {customer.MobileNumber}");
            Console.WriteLine($"Address: {customer.Address}");

            return true;
        }
    }
}
