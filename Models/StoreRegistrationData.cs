using System;
using System.ComponentModel.DataAnnotations;

namespace AdminPortal.Models
{
    public class StoreRegistrationData
    {
        [Required]
        [MinLength(5, ErrorMessage = "The field must be at least {2} characters long.")]
        [MaxLength(30, ErrorMessage = "This field just need {2} characters long.")]
        public string StoreName { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "This field must be at least {2} characters long.")]
        public string StoreShortName { get; set; }
        public string StoreFullDescription { get; set; }
        public DateTime StoreCreationDate { get; set; }
        public string StoreStatus { get; set; }
        public string UserId { get; set; }
        
    }
}