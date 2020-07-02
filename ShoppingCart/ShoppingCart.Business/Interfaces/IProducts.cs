using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business
{
    public interface IProducts
    {
        public Task<ActionResult<IEnumerable<Product>>> GetProducts();
    }
}
