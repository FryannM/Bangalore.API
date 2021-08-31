using Bangalore.API.Models;

namespace Bangalore.API.Interfaces
{
    public interface IAuthServices
    {

        AuthenticateResponse Authenticate(AuthenticateRequest model);
        Users GetById(int id);

    }
}
