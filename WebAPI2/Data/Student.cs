using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2.Data
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        public string name { get; set; }
        public int? classid { get; set; }
        [ForeignKey("classid")]
        public Class classes { get; set; }
    }
}
