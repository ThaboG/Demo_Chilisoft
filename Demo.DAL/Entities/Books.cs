using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entities
{
    [Table("Books")]
    [Index(nameof(Barcode), IsUnique = true, Name = "Index_Barcode")]
    public class Books : SyncBaseModel
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Barcode { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Total { get; set; }
    }
}
