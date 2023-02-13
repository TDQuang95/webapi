using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2.Data
{
    public class MyDbContext : DbContext
    {
        public readonly MyDbContext _context;

        public MyDbContext(DbContextOptions options) : base(options){ }

        #region dbset
        public DbSet<Class> classes { get; set; }
        public DbSet<Student> students { get; set; }
        
        #endregion
    }
}
