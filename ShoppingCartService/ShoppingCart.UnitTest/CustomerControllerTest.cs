using Moq;
using ShoppingCart.Api.Controllers;
using ShoppingCart.Common.Models;
using ShoppingCart.DataAccess.Repository;
using System.Collections.Generic;
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
        public void Get_WhenCalled_ReturnsAllCustomers()
        {
            //Arrange
            var customersMock = new Mock<IRepository<CustomerModel>>();
            customersMock.Setup(x => x.GetAll()).Returns(() => new List<CustomerModel>
            {
                new CustomerModel{ Id=1, FirstName = "Alex", LastName="Bond"},
                new CustomerModel{ Id=2, FirstName = "John", LastName="Dove"},
                new CustomerModel{ Id=3, FirstName = "Max", LastName="Mark"}
            });

            var controller = new CustomerController(customersMock.Object);

            // Act
            var result = controller.Get();

            // Assert
            var items = Assert.IsType<List<CustomerModel>>(result);
            Assert.Equal(3, items.Count);
        }
    }
}
