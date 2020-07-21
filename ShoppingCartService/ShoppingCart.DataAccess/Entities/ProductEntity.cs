using System;

namespace ShoppingCart.DataAccess.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Qty { get; set; }
        public double UnitPrice { get; set; }
        public double SellingPrice { get; set; }
        public double Discount { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public CategoryEntity Category { get; set; }
    }
}
