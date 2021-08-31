using Bangalore.API.Interfaces;
using Bangalore.API.Models;
using System.Web.Http;

namespace Bangalore.API.Controllers
{
    public class AuthController : ApiController
    {
        private readonly IAuthServices _authServices;
        public AuthController(IAuthServices authServices)
        {
            _authServices = authServices;

        }
        [HttpPost]
        //[Route(Name = ("authenticate"))]
        public IHttpActionResult Authenticate(AuthenticateRequest model)
        {
            return null;
            //var response = _authServices.Authenticate(model);
            //if (response == null) return BadRequest();
            //return Ok(response);
        }
    }
}
