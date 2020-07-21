using AutoMapper;
using ShoppingCart.Common.Model;
using ShoppingCart.DataAccess.Entities;

namespace ShoppingCart.DataAccess.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryEntity, CategoryModel>();
        }
    }
}
