using System;

namespace Bangalore.API.Models
{
    public class AccessToken
    {
        
        public string Token { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}