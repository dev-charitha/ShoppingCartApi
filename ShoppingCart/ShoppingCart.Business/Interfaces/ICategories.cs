using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCart.Business
{
    public interface ICategories
    {
        public Task<ActionResult<IEnumerable<Category>>> GetCategories();

    }
}
