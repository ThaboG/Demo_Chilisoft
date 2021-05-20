using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entities
{
    [Table("ErrorLog")]
    public class ErrorLog : SyncBaseModel
    {
        public string Message { get; set; }
    }
}
