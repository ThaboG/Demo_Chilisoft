using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entities
{
    public class Users : SyncBaseModel
    {
        [Required]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [ForeignKey("UserType")]
        public Guid UserTypeID { get; set; }
        public virtual UserTypes UserType { get; set; }
        public virtual UserGeneralUserRel GeneralUserRel  { get; set; }
        public virtual UserEmployeeRel UserEmployeeRel  { get; set; }
        public virtual UserAdminRel UserAdminRel { get; set; }
        public bool IsAdmin => UserType.UserType == Enums.UserTypes.Admin;
        public bool IsEmployee => UserType.UserType == Enums.UserTypes.Employee;
        public bool IsClient => UserType.UserType == Enums.UserTypes.Client;
    }
}
