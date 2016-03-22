using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst.Classes
{
    public class Sphere
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Category> Categories { get; set; }
    }
}
