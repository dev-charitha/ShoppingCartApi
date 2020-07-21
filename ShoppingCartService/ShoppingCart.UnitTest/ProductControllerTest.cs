using Moq;
using ShoppingCart.Api.Controllers;
using ShoppingCart.Business.Interfaces;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.DataAccess.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ShoppingCart.UnitTest
{
    public class ProductControllerTest
    {
        private IProductManager manager;
        /// <summary>
        /// Return all products when call Get function.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Get_WhenCalled_ReturnsAllProducts()
        {
            //Arrange
            var productsMock = new Mock<IProductRepository<Product>>();
            productsMock.Setup(x => x.GetAll()).Returns(() => new List<Product>
            {
                new Product{ Id=1, Name = "Samsung Galaxy S10"},
                new Product{ Id=2, Name = "Samsung LED TV"},
                new Product{ Id=3, Name = "Apple IPhone 6S"}
            });

            var controller = new ProductController(productsMock.Object, manager);

            // Act
            var result = controller.Get();

            // Assert
            var items = Assert.IsType<List<Product>>(result);
            Assert.Equal(3, items.Count);
        }

        /// <summary>
        /// Return product when provide product id.
        /// </summary>
        /// <param name="id"></param>
        [Theory]
        [InlineData(1)]
        public async Task Get_WhenCalled_ReturnsProductsByCategoryId(int id)
        {
            //Arrange
            var productsMock = new Mock<IProductRepository<Product>>();
            productsMock.Setup(x => x.GetProductByCategoryId(id)).Returns(() => new List<Product>
            {
                new Product{ Id=1, Name = "Dell Core I7 Laptop", UnitPrice=100.00, SellingPrice=150.00},
                new Product{ Id=2, Name = "Samsung Galaxy S10", UnitPrice=200.00, SellingPrice=250.00},
                new Product{ Id=3, Name = "Apple Iphone 6S", UnitPrice=400.00, SellingPrice=450.00}
            });

            var controller = new ProductController(productsMock.Object, manager);

            // Act
            var result = controller.GetProductByCategory(id);

            // Assert
            var items = Assert.IsType<List<Product>>(result);
            Assert.NotEqual(2, items.Count);
        }
    }
}
