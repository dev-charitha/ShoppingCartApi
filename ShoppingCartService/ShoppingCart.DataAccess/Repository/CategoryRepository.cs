using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Common.Model;
using ShoppingCart.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.DataAccess.Repository
{
    public class CategoryRepository : IRepository<CategoryModel>
    {
        private readonly IMapper _mapper;
        public CategoryRepository(IMapper mapper)
        {
            _mapper = mapper;
        }  
        public IEnumerable<CategoryModel> GetAll()
        {
            using (var context = new ShoppingCartDbContext())
            {
                var result = context.Category.Include(a => a.Product).ToList();
                return _mapper.Map<List<CategoryModel>>(result);

            }
        }

        public CategoryModel GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(CategoryModel obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryModel obj)
        {
            throw new NotImplementedException();
        }
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
