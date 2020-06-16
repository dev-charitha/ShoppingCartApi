using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business
{
    public interface ICategories
    {
        //Task<IEnumerable<Category>> GetAllCategory();
        public List<Category> GetCategories();
        public ActionResult<Category> AddCategories(Category categoryItem);

    }
}
