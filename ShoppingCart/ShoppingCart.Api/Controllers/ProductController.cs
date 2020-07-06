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
        private IProducts iproducts;
        public ProductController(IProducts _iproducts)
        {
            iproducts = _iproducts;
        }

        /// <summary>
        /// Return All Products.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/products")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            //throw new Exception("Test Exception product");
            return await iproducts.GetProducts();
        }

        [HttpGet("/api/products/categories/{id}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByCategoryId(int id)
        {
            return await iproducts.GetProductsByCategoryId(id);
        }
    }
}
