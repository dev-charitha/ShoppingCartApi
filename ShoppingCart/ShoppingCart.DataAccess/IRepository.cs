using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
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
        #endregion
    }
}
