﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using ShoppingCart.Api.Controllers;
using ShoppingCart.Business;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ShoppingCartUnitTest
{
    public class ProductControllerTest : ControllerBase
    {
        ILogger logger;
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

            var controller = new ProductController((ILogger<ProductController>)logger, productsMock.Object);

            // Act
            var result = await controller.GetProducts();

            // Assert
            var items = Assert.IsType<List<Product>>(result.Value);
            Assert.Equal(3, items.Count);
        }
    }
}