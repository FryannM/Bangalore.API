using Bangalore.API.AppDbContext;
using Bangalore.API.Helpers;
using Bangalore.API.Interfaces;
using Bangalore.API.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Bangalore.API.Services
{
    public class AuthServices : IAuthServices
    {
        private readonly AppSettings _appSettings;
        private readonly ApplicationDbContex _userServices;

        public AuthServices(ApplicationDbContex userServices)
        {
            _userServices = userServices;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)


        {
            var user = _userServices.Users.SingleOrDefault(x => x.UserName == model.Username && x.PassWord == model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public Users GetById(int id)
        {
            return _userServices.Users.Find(id);
        }

        // helper methods

        private string generateJwtToken(Users user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}