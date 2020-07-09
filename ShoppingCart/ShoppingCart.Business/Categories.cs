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
        /// Return all categoris to the controller.
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _repository.GetCategories();
        }

    }
}
