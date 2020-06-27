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

        //public async Task<ActionResult<IEnumerable<Category>>> GetCategory()
        //{
        //    var results= await _categories.GetAllCategory();
        //    return Ok(results);
        //}

        [HttpGet("/api/categories")]
        public ActionResult<List<Category>> GetCategories()
        {
            return _icategories.GetCategories();
        }

        [HttpPost("/api/categories")]
        public ActionResult<Category> AddProduct(Category category)
        {
            _icategories.AddCategories(category);
            return category;
        }

    }
}
