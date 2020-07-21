using Moq;
using ShoppingCart.Api.Controllers;
using ShoppingCart.Business.Interfaces;
using ShoppingCart.Common.Model;
using ShoppingCart.DataAccess.Repository;
using System.Collections.Generic;
using Xunit;

namespace ShoppingCart.UnitTest
{
    public class ProductControllerTest
    {
        private readonly IProductManager _manager;
        public ProductControllerTest(IProductManager manager)
        {
            _manager = manager;
        }

        /// <summary>
        /// Return all products when call Get function.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void Get_WhenCalled_ReturnsAllProducts()
        {
            //Arrange
            var productsMock = new Mock<IProductRepository<ProductModel>>();
            productsMock.Setup(x => x.GetAll()).Returns(() => new List<ProductModel>
            {
                new ProductModel{ Id=1, Name = "Samsung Galaxy S10"},
                new ProductModel{ Id=2, Name = "Samsung LED TV"},
                new ProductModel{ Id=3, Name = "Apple IPhone 6S"}
            });

            var controller = new ProductController(productsMock.Object, _manager);

            // Act
            var result = controller.Get();

            // Assert
            var items = Assert.IsType<List<ProductModel>>(result);
            Assert.Equal(3, items.Count);
        }

        /// <summary>
        /// Return product when provide product id.
        /// </summary>
        /// <param name="id"></param>
        [Theory]
        [InlineData(1)]
        public void Get_WhenCalled_ReturnsProductsByCategoryId(int id)
        {
            //Arrange
            var productsMock = new Mock<IProductRepository<ProductModel>>();
            productsMock.Setup(x => x.GetProductByCategoryId(id)).Returns(() => new List<ProductModel>
            {
                new ProductModel{ Id=1, Name = "Dell Core I7 Laptop", UnitPrice=100.00, SellingPrice=150.00},
                new ProductModel{ Id=2, Name = "Samsung Galaxy S10", UnitPrice=200.00, SellingPrice=250.00},
                new ProductModel{ Id=3, Name = "Apple Iphone 6S", UnitPrice=400.00, SellingPrice=450.00}
            });

            var controller = new ProductController(productsMock.Object, _manager);

            // Act
            var result = controller.GetProductByCategory(id);

            // Assert
            var items = Assert.IsType<List<ProductModel>>(result);
            Assert.NotEqual(2, items.Count);
        }
    }
}
