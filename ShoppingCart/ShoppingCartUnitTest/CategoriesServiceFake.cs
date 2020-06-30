using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Business;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartUnitTest
{
    public class CategoriesServiceFake : ICategories
    {
        private readonly List<Category> _categoryList;
        public CategoriesServiceFake()
        {
            _categoryList = new List<Category>()
            {
                new Category() { Id = 1, CategoryName = "Sport"},
                new Category() { Id = 2, CategoryName = "Electronic"},
                new Category() { Id = 3, CategoryName = "Kids"}
            };
        }
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return  _categoryList;
        }
    }
}
