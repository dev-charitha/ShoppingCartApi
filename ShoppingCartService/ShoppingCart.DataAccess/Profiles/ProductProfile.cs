using AutoMapper;
using ShoppingCart.Common.Model;
using ShoppingCart.DataAccess.Entities;

namespace ShoppingCart.DataAccess.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductEntity, ProductModel>();
        }
    }
}
