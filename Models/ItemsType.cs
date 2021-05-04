using System;
using System.ComponentModel.DataAnnotations;

namespace AdminPortal.Models
{
    public class ItemsType
    {
        [Key]
        public int ItemTypeId { get; set; }
        [Required]
        public string ItemTypeDescription { get; set; }
        public int StoreId { get; set; }
        public string ItemTypeStatus { get; set; }
        public DateTime ItemTypeCreationDate { get; set; }
        public DateTime ItemTypeModifiedDate { get; set; }
    }
}