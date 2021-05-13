using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Entities
{
    public class UserTypes : SyncBaseModel
    {
        public string Name { get; set; }
        public Enums.UserTypes UserType { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
