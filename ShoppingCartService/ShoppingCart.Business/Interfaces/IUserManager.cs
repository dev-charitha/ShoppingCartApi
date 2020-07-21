using ShoppingCart.Common.Model;
using System.Collections.Generic;

namespace ShoppingCart.Business.Interfaces
{
    public interface IUserManager
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<JwtUser> GetAll();
        JwtUser GetById(int id);
    }
}
