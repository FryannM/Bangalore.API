using Bangalore.API.Models;
using Bangalores.CORE.Abstract;
using Bangalores.CORE.Dtos;
using System.Collections.Generic;

namespace Bangalores.CORE.Interfaces
{
    public interface IUserServices
    {
        IEnumerable<Users> GetUsers();
        UserDto GetUserById(int Id);
        OperationResult<Users> SaveUser(UserDto theUser);
        OperationResult<Users> UpdateUser (int id,UserDto theUser);
        OperationResult<Users> DeleteUser(int id);
    }
}
