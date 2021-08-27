using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bangalore.API.Models
{
    public class Users
    {

        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// First Name of the User
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Middle Name of the User
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// LastName of the User
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Phone Number of the User
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Flag to check if User was delete it. thats call a soft removed
        /// </summary>
        public bool WasDeleted { get; set; }
    }
}