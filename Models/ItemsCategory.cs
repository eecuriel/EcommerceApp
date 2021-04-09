using System;
using System.ComponentModel.DataAnnotations;

namespace AdminPortal.Models
{
    public class ItemsCategory
    {
        [Key]
        public int ItemCategoryId { get; set; }
        [Required]
        public string ItemCategoryDescription { get; set; }
        public int StoreId { get; set; }
        public string ItemCetegoryStatus { get; set; }
        public DateTime ItemCategoryCreationDate { get; set; }
        public DateTime ItemCategoryModifiedDate { get; set; }
    }
}