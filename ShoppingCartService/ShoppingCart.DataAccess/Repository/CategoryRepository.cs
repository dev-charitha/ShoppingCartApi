using Microsoft.EntityFrameworkCore;
using ShoppingCart.DataAccess.Context;
using ShoppingCart.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.DataAccess.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        public IEnumerable<Category> GetAll()
        {
            using (var context = new ShoppingCartDbContext())
            {
                return context.Category.Include(a=> a.Product).ToList();
            
            }
        }

        public Category GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Category obj)
        {
            throw new NotImplementedException();
        }
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
