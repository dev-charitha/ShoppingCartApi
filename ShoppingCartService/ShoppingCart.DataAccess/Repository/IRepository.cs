using System.Collections.Generic;

namespace ShoppingCart.DataAccess.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
