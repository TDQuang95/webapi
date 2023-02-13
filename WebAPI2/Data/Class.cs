using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2.Data
{
    [Table("Class")]
    public class Class
    {
        [Key]
        public int classid { get; set; }
        [Required]
        [MaxLength(50)]
        public string classname { get; set; }
    }
}
