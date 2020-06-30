using Microsoft.Extensions.Logging;
using ShoppingCart.Api.Controllers;
using ShoppingCart.Business;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ShoppingCartUnitTest
{
    public class ProductControllerTest
    {
        ProductController _controller;
        IProducts _service;
        ILogger _logger;

        public ProductControllerTest()
        {
            _service = new ProductsServiceFake();
            _controller = new ProductController((ILogger<ProductController>)_logger, _service);
        }

        [Fact]
        public async void Get_WhenCalled_ReturnsAllProducts()
        {
            // Act
            var okResult = await _controller.GetProducts();

            // Assert
            var items = Assert.IsType<List<Product>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
    }
}
