using Microsoft.EntityFrameworkCore;
using ShoppingCart.DataAccess.Context;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T:class
    {
        private readonly ShoppingCartDbContext context = null;
        private readonly DbSet<T> table = null;

        public Repository() 
        {
            this.context = new ShoppingCartDbContext();
            table = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
