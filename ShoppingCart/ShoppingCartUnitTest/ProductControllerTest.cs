using Microsoft.AspNetCore.Mvc;
using Moq;
using ShoppingCart.Api.Controllers;
using ShoppingCart.Business;
using ShoppingCart.DataAccess.Models;
using System.Collections.Generic;
using Xunit;

namespace ShoppingCartUnitTest
{
    public class ProductControllerTest : ControllerBase
    {
        [Fact]
        public async void Get_WhenCalled_ReturnsAllProducts()
        {
            //Arrange
            var productsMock = new Mock<IProducts>();
            productsMock.Setup(x => x.GetProducts()).ReturnsAsync(() => new List<Product>
            {
                new Product{ Id=1, Name = "Dell Core I7 Laptop"},
                new Product{ Id=2, Name = "Apple 6S"},
                new Product{ Id=3, Name = "Cannon R5"}
            });

            var controller = new ProductController(productsMock.Object);

            // Act
            var result = await controller.GetProducts();

            // Assert
            var items = Assert.IsType<List<Product>>(result.Value);
            Assert.Equal(3, items.Count);
        }

        [Theory]
        [InlineData(1)]
        public async void Get_WhenCalled_ReturnsProductsByCategoryId(int id)
        {
            //Arrange
            var productsMock = new Mock<IProducts>();
            productsMock.Setup(x => x.GetProductsByCategoryId(id)).ReturnsAsync(() => new List<Product>
            {
                new Product{ Id=1, Name = "Dell Core I7 Laptop"},
                new Product{ Id=2, Name = "HP Core I5 Laptop"},
                new Product{ Id=3, Name = "Apple Iphone 6S"}
            });

            var controller = new ProductController(productsMock.Object);

            // Act
            var result = await controller.GetProductsByCategoryId(id);

            // Assert
            var items = Assert.IsType<List<Product>>(result.Value);
            Assert.Equal(2, items.Count);
        }
    }
}
