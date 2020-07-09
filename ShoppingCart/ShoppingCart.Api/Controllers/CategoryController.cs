using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Business;
using ShoppingCart.DataAccess.Models;

namespace ShoppingCart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategories icategories;
        public CategoryController(ICategories _icategories) 
        {
            icategories = _icategories;
        }

        /// <summary>
        /// Return all categoris.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/categories")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await icategories.GetCategories();
        }

    }
}
