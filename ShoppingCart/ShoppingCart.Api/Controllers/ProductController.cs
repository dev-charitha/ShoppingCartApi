using System;
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
        /// Return all products.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/products")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await iproducts.GetProducts();
        }


        /// <summary>
        /// Return product when provide a category id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("/api/products/categories/{id}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByCategoryId(int id)
        {
            return await iproducts.GetProductsByCategoryId(id);
        }
    }
}
