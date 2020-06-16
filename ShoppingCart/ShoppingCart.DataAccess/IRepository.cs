using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DataAccess
{
    public interface IRepository
    {
        //IEnumerable<Category> GetAllCategory();
        public List<Category> GetCategories();
        public ActionResult<Category> AddCategories(Category categoryItem);
    }
}
