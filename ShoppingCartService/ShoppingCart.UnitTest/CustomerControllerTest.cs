using Moq;
using ShoppingCart.Api.Controllers;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.DataAccess.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ShoppingCart.UnitTest
{
    public class CustomerControllerTest
    {
        /// <summary>
        /// Return all customers when call Get function.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Get_WhenCalled_ReturnsAllCustomers()
        {
            //Arrange
            var customersMock = new Mock<IRepository<Customer>>();
            customersMock.Setup(x => x.GetAll()).Returns(() => new List<Customer>
            {
                new Customer{ Id=1, FirstName = "Alex", LastName="Bond"},
                new Customer{ Id=2, FirstName = "John", LastName="Dove"},
                new Customer{ Id=3, FirstName = "Max", LastName="Mark"}
            });

            var controller = new CustomerController(customersMock.Object);

            // Act
            var result = controller.Get();

            // Assert
            var items = Assert.IsType<List<Customer>>(result);
            Assert.Equal(3, items.Count);
        }
    }
}
