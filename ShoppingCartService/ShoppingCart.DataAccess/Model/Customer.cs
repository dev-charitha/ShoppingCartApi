using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DataAccess.Model
{
    public class Customer
    {
        public int Id  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual User User { get; set; }

    }
}
