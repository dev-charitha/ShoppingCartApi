﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoppingCart.Business;
using ShoppingCart.DataAccess.Models;

namespace ShoppingCart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ILogger _logger;
        private IProducts _service;


        public ProductController(ILogger<ProductController> logger, IProducts service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/products")]
        public ActionResult<List<Product>> GetProducts()
        {
            return _service.GetProducts();
        }

        //[HttpPost("/api/products")]
        //public ActionResult<Product> AddProduct(Product product)
        //{
        //    _service.AddProduct(product);
        //    return product;
        //}

        //[HttpPut("/api/products/{id}")]
        //public ActionResult<Product> UpdateProduct(string id, Product product)
        //{
        //    _service.UpdateProduct(id, product);
        //    return product;
        //}

        //[HttpDelete("/api/products/{id}")]
        //public ActionResult<string> DeleteProduct(string id)
        //{
        //    _service.DeleteProduct(id);
        //    //_logger.LogInformation("products", _products);
        //    return id;
        //}
    }
}
