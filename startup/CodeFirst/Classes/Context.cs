using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst.Classes
{
    public class Context : DbContext
    {
        public Context() : base("StartDatabase")
        {

        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sphere> Spheres { get; set; }

    }
}
