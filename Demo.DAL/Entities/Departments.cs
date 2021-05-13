using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entities
{
    [Table("Departments")]
    public class Departments : SyncBaseModel
    {
        public string Name { get; set; }
        public ICollection<Employees> Employees { get; set; }
    }
}
