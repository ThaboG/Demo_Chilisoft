using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Inteface
{
    public interface IDataModel
    {
        /*[Required]*/
        Guid ID { get; set; }
        DateTimeOffset CreateDateTime { get; set; }
        bool IsDeleted { get; set; }
    }
}
