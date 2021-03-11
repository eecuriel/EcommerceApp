using System;
using System.ComponentModel.DataAnnotations;

namespace AdminPortal.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }

        [Required]
        public string StoreName { get; set; }

        [Required]
        public string StoreShortName { get; set; }
        public string StoreFullDescription { get; set; }
        public string UserId { get; set; }
        public string StoreOwnerName { get; set; }
        public string StoreOwerSurname { get; set; }
        public string StoreAddress1 { get; set; }
        public string StoreAddress2 { get; set; }
        public string StorePhone { get; set; }
        public string StroreContactEmail { get; set; }
        public string StorePostalCode { get; set; }
        public string StoreLongitude { get; set; }
        public string StoreLatitude { get; set; }
        public string StoreLogoImage { get; set; }
        public string StoreStatus { get; set; }
        public DateTime StoreCreationDate { get; set; }
        public DateTime StoreLastModifiedDate { get; set; }

    }
}