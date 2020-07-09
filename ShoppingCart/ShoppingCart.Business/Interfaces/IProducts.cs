using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCart.Business
{
    public interface IProducts
    {
        public Task<ActionResult<IEnumerable<Product>>> GetProducts();
        public Task<ActionResult<IEnumerable<Product>>> GetProductsByCategoryId(int id);
    }
}
