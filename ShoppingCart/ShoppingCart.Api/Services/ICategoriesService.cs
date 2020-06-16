using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Api.Services
{
    public interface ICategoriesService
    {
        public List<Category> GetCategories();
    }
}
