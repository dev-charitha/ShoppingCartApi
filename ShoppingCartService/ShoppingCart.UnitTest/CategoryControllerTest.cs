using Moq;
using ShoppingCart.Api.Controllers;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.DataAccess.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task Get_WhenCalled_ReturnsAllCategories()
        {
            //Arrange
            var categoriesMock = new Mock<IRepository<Category>>();
            categoriesMock.Setup(x => x.GetAll()).Returns(() => new List<Category>
            {
                new Category{ Id=1, Name = "Sport"},
                new Category{ Id=2, Name = "Electronic"},
                new Category{ Id=3, Name = "Electronic"}
            });

            var controller = new CategoryController(categoriesMock.Object);

            // Act
            var result = controller.Get();

            // Assert
            var items = Assert.IsType<List<Category>>(result);
            Assert.Equal(3, items.Count);
        }
    }
}
