using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entities
{
    [Table("Employees")]
    public class Employees : Profile
    {
        [Required(ErrorMessage = "Employee Number is required")]
        [Display(Name = "Employee Number")]
        public string EmployeeNo { get; set; }
        [ForeignKey("Department")]
        public Guid DepartmentID { get; set; }
        public virtual Departments Department { get; set; }
        public virtual UserEmployeeRel UserEmployeeRel { get; set; }
    }
}
