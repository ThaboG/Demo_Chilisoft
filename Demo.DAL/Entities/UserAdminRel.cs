using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entities
{
    [Table("UserAdminRel")]
    public class UserAdminRel : BaseModel
    {
        [ForeignKey("User")]
        public Guid UserID { get; set; }
        [ForeignKey("Admin")]
        public Guid AdminID { get; set; }

        public virtual Users User { get; set; }
        public virtual Admins Admin { get; set; }
    }
}
