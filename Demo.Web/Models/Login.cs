using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email Required", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "Please enter a valid Email address")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password Required", AllowEmptyStrings = false)]
        [Display(Name = "Access Token/Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember Me?")]
        public bool IsRememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
