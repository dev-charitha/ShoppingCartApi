using System.Collections.Generic;
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
        /// Return All Categoris.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/categories")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            //throw new Exception("Test Exception");
            return await icategories.GetCategories();
        }

    }
}
