using AutoMapper;
using ShoppingCart.Common.Models;
using ShoppingCart.DataAccess.Entities;

namespace ShoppingCart.DataAccess.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<UserEntity, UserModel>();
        }
    }
}
