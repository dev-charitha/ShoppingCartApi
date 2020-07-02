using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using ShoppingCart.Api.Controllers;
using ShoppingCart.Business;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShoppingCartUnitTest
{
    public class CategoryControllerTest : ControllerBase
    {
        ILogger logger;
        [Fact]
        public async Task Get_WhenCalled_ReturnsAllCategories()
        {
            //Arrange
            var categoriesMock = new Mock<ICategories>();
            categoriesMock.Setup(x => x.GetCategories()).ReturnsAsync(() => new List<Category>
            {
                new Category{ Id=1, CategoryName = "Sport"},
                new Category{ Id=2, CategoryName = "Electronic"},
                new Category{ Id=3, CategoryName = "Electronic"}
            });

            var controller = new CategoryController((ILogger<CategoryController>) logger, categoriesMock.Object);

            // Act
            var result = await controller.GetCategories();

            // Assert
            var items = Assert.IsType<List<Category>>(result.Value);
            Assert.Equal(3, items.Count);
        }
    }
}
