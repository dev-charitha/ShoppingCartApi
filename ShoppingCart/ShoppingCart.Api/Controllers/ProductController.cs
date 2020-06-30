using System;
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

        /// <summary>
        /// Return All Products.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/products")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _service.GetProducts();
        }
    }
}
