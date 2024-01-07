using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCWithEFCF8.Models
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext() : base("ConStr")
        {
        }
        public DbSet<Student> Students { get; set; }

    }
}