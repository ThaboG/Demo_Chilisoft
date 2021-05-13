using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.DAL.Entities
{
    public abstract class SyncBaseModel : BaseModel
    {
        [ScaffoldColumn(false)]
        public DateTimeOffset SyncTime { get; set; }
        [ScaffoldColumn(false)]
        public Guid SyncClientID { get; set; }
    }
}
