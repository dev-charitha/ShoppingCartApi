
using System;

namespace ShoppingCart.Common.Models
{
    public class CustomerModel : UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual UserModel User { get; set; }
    }
}
