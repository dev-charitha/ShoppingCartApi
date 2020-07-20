using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.DataAccess.Repository;
using System;
using System.Collections.Generic;

namespace ShoppingCart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IRepository<Category> _category;
        public CategoryController(IRepository<Category> category)
        {
            _category = category;
        }

        /// <summary>
        /// Return all categories.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/getcategory")]
        public IEnumerable<Category> Get()
        {
            throw new Exception("Test Exception");
            var result = _category.GetAll();
            return result;
        }
    }
}
