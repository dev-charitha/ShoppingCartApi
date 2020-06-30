using System;
using System.Collections;
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
    public class CategoryController : ControllerBase
    {
        private ILogger _logger;
        private ICategories _icategories;

        public CategoryController(ILogger<CategoryController> logger, ICategories icategories) 
        {
            _logger = logger;
            _icategories = icategories;
        }

        /// <summary>
        /// Return All Categoris.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/categories")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        { 
            var result = await _icategories.GetCategories();
            return Ok(result);
        }

    }
}
