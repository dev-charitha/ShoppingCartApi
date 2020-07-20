
using Microsoft.EntityFrameworkCore;
using ShoppingCart.DataAccess.Context;
using ShoppingCart.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.DataAccess.Repository
{
    public class ProductRepository : IProductRepository<Product>
    {
        public IEnumerable<Product> GetAll()
        {
            using (var context = new ShoppingCartDbContext())
            {
                var test = context.Product.Include(p => p.Category).Where(a=> a.IsActive).ToList();
                
                return test;

            }
        }

        public IEnumerable<Product> GetProductByCategoryId(int id)
        {
            using (var context = new ShoppingCartDbContext())
            {
                var test = context.Product.Include(p => p.Category).Where(b=> b.Category.Id==id).ToList();
                return test;
            }
        }

        public Product GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Product obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
