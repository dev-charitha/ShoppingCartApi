using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Business;
using ShoppingCart.DataAccess.Models;

namespace ShoppingCart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProducts _service;


        public ProductController(IProducts service)
        {
            _service = service;
        }

        /// <summary>
        /// Return All Products.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/products")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            //throw new Exception("Test Exception product");
            return await _service.GetProducts();
        }
    }
}
