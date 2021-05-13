using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entities
{
    [Table("UserEmployeeRel")]
    public class UserEmployeeRel : BaseModel
    {
        [ForeignKey("User")]
        public Guid UserID { get; set; }
        [ForeignKey("Employee")]
        public Guid EmployeeID { get; set; }

        public virtual Users User { get; set; }
        public virtual Employees Employee { get; set; }
    }
}
