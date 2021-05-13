using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entities
{
    [Table("UserGeneralUsertRel")]
    public class UserGeneralUserRel : BaseModel
    {
        [ForeignKey("User")]
        public Guid UserID { get; set; }
        [ForeignKey("GeneralUser")]
        public Guid GeneralUsersID { get; set; }

        public virtual Users User { get; set; }
        public virtual GeneralUsers GeneralUser { get; set; }
    }
}
