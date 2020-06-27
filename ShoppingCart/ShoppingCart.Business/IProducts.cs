using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Business
{
    public interface IProducts
    {
        public List<Product> GetProducts();
    }
}
