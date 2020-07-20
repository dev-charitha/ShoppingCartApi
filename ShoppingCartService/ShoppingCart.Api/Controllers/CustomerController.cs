using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.DataAccess.Repository;

namespace ShoppingCart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly IRepository<Customer> _customer;
        public CustomerController(IRepository<Customer> customer)
        {
            _customer = customer;
        }

        /// <summary>
        /// Add new customer when provide customer object
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost("/api/addcustomer")]
        public ActionResult<IEnumerable<Customer>> AddCustomer(Customer customer)
        {
            _customer.Insert(customer);
            return Ok(customer);
        }
    }
}
