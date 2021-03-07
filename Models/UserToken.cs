using System;

namespace AdminPortal.Models
{
    public class UserToken
    {
        public string token { get; set; }
        public DateTime expiration { get; set; }
        public string Id { get; set; }
    
    }
}