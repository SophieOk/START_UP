using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst.Classes
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Keywords { get; set; }
        public virtual Sphere Sphere { get; set; }

        public Category() { Keywords = new List<string>(); }
    }
}
