﻿using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business
{
    public class Products: IProducts
    {
        private readonly IRepository repository;

        public Products(IRepository _repository)
        {
            repository = _repository;
        }

        /// <summary>
        /// Return All Products to the Controller.
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await repository.GetProducts();
        }

        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByCategoryId(int id)
        {
            return await repository.GetProductsByCategoryId(id);
        }
    }
}
