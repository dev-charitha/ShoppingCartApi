using System.Collections.Generic;

namespace ShoppingCart.DataAccess.Repository
{
    public interface IProductRepository<T> : IRepository<T>
    {
        IEnumerable<T> GetProductByCategoryId(int id);
    }
}
