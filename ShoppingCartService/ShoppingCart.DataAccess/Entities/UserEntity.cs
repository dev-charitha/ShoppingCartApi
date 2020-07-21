using System.Collections.Generic;

namespace ShoppingCart.DataAccess.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual ICollection<CustomerEntity> Customer { get; set; }
    }
}
