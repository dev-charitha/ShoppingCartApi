using AutoMapper;
using ShoppingCart.Common.Models;
using ShoppingCart.DataAccess.Entities;

namespace ShoppingCart.DataAccess.Profiles
{
    class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerEntity, CustomerModel>();
        }
    }
}
