using ShoppingCart.Business;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Api.Services
{
    public class CategoriesService : ICategoriesService
    {
        private ICategoriesService _icategoriesservice;
        private ICategories _icategories;
        public CategoriesService(ICategoriesService icategoriesservice,ICategories icategories)
        {
            _icategoriesservice = icategoriesservice;
            _icategories = icategories;
        }

        public List<Category> GetCategories()
        {
            //return _productItems;
            return _icategories.GetCategories();
        }
    }
}
