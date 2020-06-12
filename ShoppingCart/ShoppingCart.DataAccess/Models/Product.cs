using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DataAccess.Models
{
    public class Product
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string ProductName { get; set; }
      
    }
}
