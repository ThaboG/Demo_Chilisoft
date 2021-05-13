using Demo.DAL.Inteface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.DAL.Entities
{
   public abstract class BaseModel : IDataModel
    {
        [ScaffoldColumn(false)]
        public Guid ID { get; set; }
        [ScaffoldColumn(false)]
        public DateTimeOffset CreateDateTime { get; set; }
        [ScaffoldColumn(false)]
        public DateTimeOffset? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
