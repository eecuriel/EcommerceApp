using System;
using System.ComponentModel.DataAnnotations;

namespace AdminPortal.Models
{
    public class StoreValidation
    {
        [Key]
        public int StoreId { get; set; }
        public string StoreName { get; set; }

        public string StoreShortName { get; set; }
        public string StoreFullDescription { get; set; }
        public string UserId { get; set; }
        public DateTime StoreCreationDate { get; set; }
        public DateTime StoreLastModifiedDate { get; set; }

    }
}