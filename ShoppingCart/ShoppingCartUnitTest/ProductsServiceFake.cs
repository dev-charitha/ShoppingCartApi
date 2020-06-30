using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Business;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartUnitTest
{
    public class ProductsServiceFake: IProducts
    {
        private readonly List<Product> _productList;

        public ProductsServiceFake()
        {
            _productList = new List<Product>()
            {
                new Product() { Id = 1, Name = "Dell Core I7 Laptop"},
                new Product() { Id = 2, Name = "Apple 6S"},
                new Product() { Id = 3, Name = "Cannon R5"}
            };
        }

        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return _productList;
        }
    }
}
