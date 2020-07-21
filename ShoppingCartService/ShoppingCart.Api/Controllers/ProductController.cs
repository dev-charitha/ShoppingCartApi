using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Business.Interfaces;
using ShoppingCart.Common.Model;
using ShoppingCart.DataAccess.Repository;
using System.Collections.Generic;
using System.Text.Json;

namespace ShoppingCart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductRepository<ProductModel> _product;
        private readonly IProductManager _productmanager;
        public ProductController(IProductRepository<ProductModel> category, IProductManager productmanager)
        {
            _product = category;
            _productmanager = productmanager;
        }

        /// <summary>
        /// Return all products.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/getproduct")]
        public IEnumerable<ProductModel> Get()
        {
            var result = _product.GetAll();
            return result;
        }

        /// <summary>
        /// Return product when provide category id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("/api/getproductbycategory/{id}")]
        public IEnumerable<ProductModel> GetProductByCategory(int id)
        {
            return _product.GetProductByCategoryId(id);
        }

        /// <summary>
        /// Return product when provide encrypted category id.
        /// </summary>
        /// <param name="encodedId"></param>
        /// <returns></returns>
        [HttpGet("/api/getproductbycategoryid/{encodedId}")]
        public ActionResult GetProductByCategoryId(string encodedId)
        {
            var encryptedString = _productmanager.GetProductByCategoryIdenc(encodedId);
            return Ok(JsonSerializer.Serialize(encryptedString));
        }
    }
}
