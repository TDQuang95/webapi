using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2.Model
{
    public class Student
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public int classid { get; set; }
    }
}
