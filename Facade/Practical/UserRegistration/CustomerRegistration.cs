namespace UserRegistration
{
    public class CustomerRegistration
    {
        public bool RegisterCustomer(Customer customer)
        {
          
            Validator validator = new Validator();
            bool IsValid = validator.ValidateCustomer(customer);


            CustomerDataAccessLayer customerDataAccessLayer = new CustomerDataAccessLayer();
            bool IsSaved = customerDataAccessLayer.SaveCustomer(customer);


            Email email = new Email();
            email.SendRegistrationEmail(customer);

            return true;
        }
    }
}
