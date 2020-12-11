using Moq;
using UnitTesting.Application;
using Xunit;

namespace UnitTesting
{
    public class Moq
    {
        [Fact]
        public void CreateCustomer_Success() {

            var customer = new Person(1, "Sunil", "Rathmalana", false);
            var mock = new Mock<ICustomerRepository>();
            mock.Setup(foo => foo.Add(It.IsAny<Person>())).Returns(customer);

            var customerService = new CustomerService(mock.Object);
            var result = customerService.Add(new Person(1, "Sunil", "Rathmalana", false));
            Assert.Equal(customer, result);
        }
        [Fact]
        public void CreateCustomer_Update()
        {
            var customer = new Person(1, "Sunil", "Rathmalana", false);
            var mock = new Mock<ICustomerRepository>();
            mock.Setup(foo => foo.Update(It.IsAny<Person>())).Verifiable();
        }
    }
}
