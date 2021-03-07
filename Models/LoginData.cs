using System;
using System.ComponentModel.DataAnnotations;

namespace AdminPortal.Models
{
    public class LoginData
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    
    }
}