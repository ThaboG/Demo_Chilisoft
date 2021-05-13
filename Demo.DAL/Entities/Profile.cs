using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.DAL.Entities
{
    public abstract class Profile : SyncBaseModel
    {
        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false)]
        public string Firstname { get; set; }
        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false)]
        public string Lastname { get; set; }
        [Display(Name = "Mobile Number")]
        public string MobileNo { get; set; }
    }
}
