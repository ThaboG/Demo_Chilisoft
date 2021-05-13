using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entities
{
    [Table("Admins")]
    public class Admins : Profile
    {
        public virtual UserAdminRel UserAdminRel { get; set; }
    }
}
