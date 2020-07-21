using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Business.Interfaces;
using ShoppingCart.Common.Model;

namespace ShoppingCart.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserManager _usermanager;

        public UserController(IUserManager usermanager)
        {
            _usermanager = usermanager;
        }

        [HttpPost("/api/authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _usermanager.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _usermanager.GetAll();
            return Ok(users);
        }
    }
}
