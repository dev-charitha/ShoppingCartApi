using ShoppingCart.Business.Interfaces;
using ShoppingCart.Common;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace ShoppingCart.Business
{
    public class ProductManager : IProductManager
    {
        private readonly IProductRepository<Product> _product;
        public ProductManager(IProductRepository<Product> category)
        {
            _product = category;
        }

        /// <summary>
        /// Return product JSON object when provide encrypted category id. 
        /// </summary>
        /// <param name="encodedId"></param>
        /// <returns></returns>
        public string GetProductByCategoryIdenc(string encodedId)
        {
            var base64EncodedId = System.Convert.FromBase64String(encodedId);
            string encryptedId = System.Text.Encoding.UTF8.GetString(base64EncodedId);
            var decryptedId = DataEncryptionHandler.DecryptStringAES(encryptedId);
            int id = int.Parse(decryptedId);

            List<Product> productList = _product.GetProductByCategoryId(id).ToList();

            var newproductList = productList.Select(a => new Product() {
                Id = a.Id,
                Name = a.Name,
                Description = a.Description,
                ImagePath=a.ImagePath,
                Qty=a.Qty,
                UnitPrice=a.UnitPrice,
                SellingPrice=a.SellingPrice,
                Discount=a.Discount,
                IsActive=a.IsActive,
                CreatedBy=a.CreatedBy,
                CreatedDate=a.CreatedDate,
            }).ToList();

            var encryptedString = DataEncryptionHandler.EncryptStringAES(JsonSerializer.Serialize(newproductList)).ToString();
            return encryptedString;
        }
    }
}
