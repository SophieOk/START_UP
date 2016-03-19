using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst.Model
{
   public class Sphere
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category> Categories { get; set; }

    }

    
}
