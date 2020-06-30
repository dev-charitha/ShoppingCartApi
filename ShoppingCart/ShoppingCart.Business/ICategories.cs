using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business
{
    public interface ICategories
    {
        public Task<ActionResult<IEnumerable<Category>>> GetCategories();

    }
}
