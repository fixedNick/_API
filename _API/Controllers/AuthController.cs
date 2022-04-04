using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //register
        // localhost:<port>/api/auth/signup POST
        [Route("signup")]
        [HttpPost]
        public IActionResult Signup()
        {

        }
    }
}
