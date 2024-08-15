
namespace Facade
{
    public class Invoice
    {
        // Subsystem 3
        // The Subsystem can accept requests either from the facade or from the client directly. 
        // In this case, from the Subsystem, the Facade is also a client
        // Facade is not a part of the Subsystem.
        public void SendInvoice()
        {
            Console.WriteLine("Invoice send successfully...");
        }
    }
}
