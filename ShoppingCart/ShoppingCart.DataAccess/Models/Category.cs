using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DataAccess.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
