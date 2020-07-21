using Moq;
using ShoppingCart.Api.Controllers;
using ShoppingCart.Common.Model;
using ShoppingCart.DataAccess.Repository;
using System.Collections.Generic;
using Xunit;

namespace ShoppingCart.UnitTest
{
    public class CategoryControllerTest
    {
        /// <summary>
        /// Return all categories when call Get function.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void Get_WhenCalled_ReturnsAllCategories()
        {
            //Arrange
            var categoriesMock = new Mock<IRepository<CategoryModel>>();
            categoriesMock.Setup(x => x.GetAll()).Returns(() => new List<CategoryModel>
            {
                new CategoryModel{ Id=1, Name = "Sport"},
                new CategoryModel{ Id=2, Name = "Electronic"},
                new CategoryModel{ Id=3, Name = "Electronic"}
            });

            var controller = new CategoryController(categoriesMock.Object);

            // Act
            var result = controller.Get();

            // Assert
            var items = Assert.IsType<List<CategoryModel>>(result);
            Assert.Equal(3, items.Count);
        }
    }
}
