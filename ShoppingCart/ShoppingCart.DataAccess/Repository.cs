using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.DataAccess
{
    public class Repository : IRepository
    {
        private readonly ContextSC _contextSC;

        public Repository() {
            _contextSC = new ContextSC();
        }

        public List<Category> GetCategories() {
            return _contextSC.Categories
                .OrderBy(p => p.Id)
                .ToList();
        }


        //Create Category
        //public async Task<ActionResult<TodoItemDTO>> CreateTodoItem(TodoItemDTO todoItemDTO)
        public ActionResult<Category> AddCategories(Category categoryItem)
        {
            var category = new Category
            {
                //Id = categoryItem.Id,
                CategoryName = categoryItem.CategoryName
            };

            _contextSC.Categories.Add(category);
            _contextSC.SaveChanges();

            return categoryItem;
        }


    }
}
