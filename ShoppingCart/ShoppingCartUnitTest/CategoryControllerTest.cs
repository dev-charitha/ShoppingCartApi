using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoppingCart.Api.Controllers;
using ShoppingCart.Business;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace ShoppingCartUnitTest
{
    public class CategoryControllerTest
    {
        CategoryController _controller;
        ICategories _service;
        ILogger _logger;

        public CategoryControllerTest()
        {
            _service = new CategoriesServiceFake();
            _controller = new CategoryController((ILogger<CategoryController>)_logger, _service);

        }

        [Fact]
        public async void Get_WhenCalled_ReturnsAllCategories()
        {
            // Act
            var okResult = await _controller.GetCategories();

            // Assert
            var items = Assert.IsType<List<Category>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
    }
}
