using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess;
using ShoppingCart.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCart.Business
{
    public class Categories : ICategories
    {
        private readonly IRepository repository;

        public Categories(IRepository _repository)
        {
            repository = _repository;
        }

        /// <summary>
        /// Return all categoris to the controller.
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await repository.GetCategories();
        }

    }
}
