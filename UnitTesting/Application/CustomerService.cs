namespace UnitTesting.Application
{
    public class CustomerService
    {
        ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public Person Add(Person person)
        {
            return _customerRepository.Add(person);
        }
    }
}
