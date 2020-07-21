using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Common.Model;
using ShoppingCart.DataAccess.Repository;
using System.Collections.Generic;

namespace ShoppingCart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IRepository<CategoryModel> _category;
        public CategoryController(IRepository<CategoryModel> category)
        {
            _category = category;
        }

        /// <summary>
        /// Return all categories.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/getcategory")]
        public IEnumerable<CategoryModel> Get()
        {
            var result = _category.GetAll();
            return result;
        }
    }
}
