using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.DataAccess
{
    public class Repository : IRepository
    {
        private readonly ContextSC _contextSC;

        public Repository() {
            _contextSC = new ContextSC();
        }

        #region Category

        /// <summary>
        /// Get All Categories from Context and Return.
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories() {
           return await _contextSC.Categories
                .OrderBy(p => p.Id)
                .ToListAsync();
        }

        #endregion

        #region Product
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _contextSC.Products
                .OrderBy(p => p.Id)
                .ToListAsync();
        }
        #endregion


    }
}
