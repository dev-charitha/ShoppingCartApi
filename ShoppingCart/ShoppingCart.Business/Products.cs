using ShoppingCart.DataAccess;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Business
{
    public class Products: IProducts
    {
        private readonly IRepository _repository;

        public Products(IRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetProducts()
        {
            return _repository.GetProducts();
        }
    }
}
