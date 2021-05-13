using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.DAL.Entities
{
    public class GeneralUsers : Profile
    {
        [Required(ErrorMessage = "Client is required")]
        [Display(Name = "Client Number")]
        public string ClientNo { get; set; }
        public virtual UserGeneralUserRel UserClientRel { get; set; }
    }
}
