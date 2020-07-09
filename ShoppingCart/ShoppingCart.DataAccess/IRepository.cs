using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess
{
    public interface IRepository
    {
        #region Category
        public Task<ActionResult<IEnumerable<Category>>> GetCategories();
        #endregion

        #region Product
        public Task<ActionResult<IEnumerable<Product>>> GetProducts();
        public Task<ActionResult<IEnumerable<Product>>> GetProductsByCategoryId(int id);
        #endregion
    }
}
