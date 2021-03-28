using System;
using System.ComponentModel.DataAnnotations;
using AdminPortal.Helpers;
using Microsoft.AspNetCore.Components.Forms;

namespace AdminPortal.Models
{
    public class StoreLogo
    {
        //[Required]
       // [StringLength(20, MinimumLength = 2)]
        public string StoreShortName { get; set; }

        //[Required]
        //[FileValidation(new[] { ".png", ".jpeg",".gif" })]
        public IBrowserFile StoreLogoImage { get; set; }
        //public string StoreLogoImage { get; set; }

    }
}