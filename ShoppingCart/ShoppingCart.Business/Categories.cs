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

        

        //public async Task<IEnumerable<Category>> GetAllCategory()
        //{
        //    var result= _repository.GetAllCategory();
        //    return result;
        //}

        //Get Category
        public List<Category> GetCategories()
        {
            return _repository.GetCategories();
        }

        //Add Category
        public ActionResult<Category> AddCategories(Category categoryItem)
        {
            _repository.AddCategories(categoryItem);
            return categoryItem;
        }


    }
}
