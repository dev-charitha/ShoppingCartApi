using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ShoppingCart.DataAccess.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
