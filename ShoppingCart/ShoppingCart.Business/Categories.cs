using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCart.Business
{
    public class Categories : ICategories
    {
        private readonly IRepository _repository;

        public Categories(IRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Return All Categoris to the Controller.
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            var result = await _repository.GetCategories();
            return result;
        }

    }
}
