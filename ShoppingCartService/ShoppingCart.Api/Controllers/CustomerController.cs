using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Common.Models;
using ShoppingCart.DataAccess.Repository;

namespace ShoppingCart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly IRepository<CustomerModel> _customer;
        public CustomerController(IRepository<CustomerModel> customer)
        {
            _customer = customer;
        }

        /// <summary>
        /// Return all customer.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/getcustomer")]
        public IEnumerable<CustomerModel> Get()
        {
            var result = _customer.GetAll();
            return result;
        }

        /// <summary>
        /// Add new customer when provide customer object
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost("/api/addcustomer")]
        public ActionResult<IEnumerable<CustomerModel>> AddCustomer(CustomerModel customer)
        {
            _customer.Insert(customer);
            return Ok(customer);
        }
    }
}
