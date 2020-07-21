using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Common.Models;
using ShoppingCart.DataAccess.Context;
using ShoppingCart.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.DataAccess.Repository
{
    public class CustomerRepository : IRepository<CustomerModel>
    {
        private readonly IMapper _mapper;
        public CustomerRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IEnumerable<CustomerModel> GetAll()
        {
            using (var context = new ShoppingCartDbContext())
            {
                var result = context.Customer.Include(a => a.User).ToList();
                return _mapper.Map<List<CustomerModel>>(result);
            }
        }

        public CustomerModel GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(CustomerModel obj)
        {
            if (obj != null)
            {
                CustomerEntity customerEntity;
                using (var context = new ShoppingCartDbContext())
                {
                    customerEntity = new CustomerEntity()
                    {
                        FirstName = obj.FirstName,
                        LastName = obj.LastName,
                        Email = obj.Email,
                        HouseNo = obj.HouseNo,
                        Street = obj.Street,
                        City = obj.City,
                        IsActive = true,
                        CreatedDate = obj.CreatedDate,
                        User = new UserEntity()
                        { 
                            UserName = obj.UserName,
                            Password = obj.Password
                        }
                    };
                    context.Customer.Add(customerEntity);
                    context.SaveChanges();
                }
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerModel obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
