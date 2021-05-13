using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entities
{
    [Table("BooksRegister")]
    public class BooksRegister
    {
        [ForeignKey("Books")]
        public Guid BooksID { get; set; }
        public Books Books { get; set; }
    }
}
