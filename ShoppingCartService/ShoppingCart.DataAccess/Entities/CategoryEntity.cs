using System;
using System.Collections.Generic;

namespace ShoppingCart.DataAccess.Entities
{
    public class CategoryEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<ProductEntity> Product { get; set; }
    }
}
