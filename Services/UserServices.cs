using AutoMapper;
using Bangalore.API.AppDbContext;
using Bangalore.API.Models;
using Bangalores.CORE.Abstract;
using Bangalores.CORE.Dtos;
using Bangalores.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bangalores.CORE.Services
{
    public class UserServices : IUserServices
    {
        private readonly ApplicationDbContex _userServices;
        private readonly IMapper _mapper;
        public UserServices(ApplicationDbContex userServices, IMapper mapper)
        {
            _userServices = userServices;
            _mapper = mapper;

        }
        /// <summary>
        /// Get the User By Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public UserDto GetUserById(int Id)
        {
            var Model = _userServices.Users.FindAsync(Id);

            return _mapper.Map<UserDto>(Model);
        }


        public IEnumerable<Users> GetUsers()
        {
            return _userServices.Users.Where(x => x.WasDeleted == false);
        }

        public OperationResult<Users> SaveUser(UserDto theUser)
        {
            var result = new OperationResult<Users>();
            try
            {
                var MapModel = _mapper.Map<Users>(theUser);
                _userServices.Users.Add(MapModel);
                _userServices.SaveChanges();
                result.Success = true;
                result.ResultObject = MapModel;
            }
            catch (Exception ex)
            {
                result.Success = false;
                throw ex;
            }
            return result;
        }

        public OperationResult<Users> UpdateUser(int id, UserDto theUser)
        {
            var result = new OperationResult<Users>();

            var modelSearch = _userServices.Users.Find(id);
            if (modelSearch == null) return null;

            try
            {
                var modelMap = _mapper.Map<Users>(theUser);
                _userServices.Users.Update(modelMap);
                _userServices.SaveChanges();
                result.Success = true;
                result.ResultObject = modelMap;
            }
            catch (Exception ex)
            {
                result.Success = false;
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// Soft Delete  for the users
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OperationResult<Users> DeleteUser(int id)
        {
            var result = new OperationResult<Users>();
            try
            {
                var UserModel = _userServices.Users.Find(id);
                var modelo = _mapper.Map<Users>(UserModel);
                modelo.WasDeleted = true;
                _userServices.Users.Update(modelo);

                _userServices.SaveChanges();
                result.Success = true;
                result.ResultObject = modelo;
            }
            catch (Exception ex)
            {
                result.Success = false;
                throw ex;
            }
            return result;
        }

    }
}
