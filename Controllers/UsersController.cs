using Bangalores.CORE.Dtos;
using Bangalores.CORE.Interfaces;
using System.Web.Http;

namespace Bangalore.API.Controllers
{
    public class UsersController : ApiController
    {

        private readonly IUserServices _userServices;
        public UsersController(IUserServices userServices)
        {
            _userServices = userServices;

        }
        // GET: api/Users
        public IHttpActionResult Get() => Ok(_userServices.GetUsers());


        // GET: api/Users/5
        public IHttpActionResult Get(int id)
        {
            var model = _userServices.GetUserById(id);
            if (model != null) return Ok(model);
            return NotFound();
        }

        [HttpPost]
        [Route(Name = "saveUser")]
        public IHttpActionResult Post([FromBody] UserDto theModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            var createModel = _userServices.SaveUser(theModel);

            return CreatedAtRoute("saveUser", new { id = theModel.Id }, createModel);
        }

        // PUT: api/Users/5
        [HttpPut]
        [Route("users/{id}")]
        public IHttpActionResult Put(int id, [FromBody] UserDto theModel)
        {
            if (ModelState.IsValid) return BadRequest();
            var modelUpdated = _userServices.UpdateUser(id, theModel);
            if (modelUpdated == null) return NotFound();
            return Ok(modelUpdated);
        }

        // DELETE: api/Users/5
        public IHttpActionResult Delete(int id)
        {
            if (id != default)
            {
                var softDeleteUser = _userServices.DeleteUser(id);
                if (softDeleteUser == null) return BadRequest();
                return Ok(softDeleteUser);
            }
            return NotFound();
        }
    }
}
