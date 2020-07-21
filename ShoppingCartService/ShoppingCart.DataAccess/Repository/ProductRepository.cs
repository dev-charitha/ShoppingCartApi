
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Common.Model;
using ShoppingCart.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.DataAccess.Repository
{
    public class ProductRepository : IProductRepository<ProductModel>
    {
        private readonly IMapper _mapper;
        public ProductRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IEnumerable<ProductModel> GetAll()
        {
            using (var context = new ShoppingCartDbContext())
            {
                var result = context.Product.Include(p => p.Category).Where(a=> a.IsActive).ToList();
                return _mapper.Map<List<ProductModel>>(result);
            }
        }

        public IEnumerable<ProductModel> GetProductByCategoryId(int id)
        {
            using (var context = new ShoppingCartDbContext())
            {
                var result = context.Product.Include(p => p.Category).Where(b=> b.Category.Id==id).ToList();
                return _mapper.Map<List<ProductModel>>(result);
            }
        }

        public ProductModel GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductModel obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductModel obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
