using ShoppingCart.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Business.Interfaces
{
    public interface IUserManager
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<JwtUser> GetAll();
        JwtUser GetById(int id);
    }
}
