using Microsoft.EntityFrameworkCore;
using ShoppingCart.DataAccess.Context;
using ShoppingCart.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.DataAccess.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        public IEnumerable<Customer> GetAll()
        {
            using (var context = new ShoppingCartDbContext())
            {
                return context.Customer.Include(a => a.User).ToList();
            }
        }

        public Customer GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Customer obj)
        {
            if (obj != null)
            {
                using var context = new ShoppingCartDbContext();

                context.Customer.Add(obj);
                context.SaveChanges();
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
