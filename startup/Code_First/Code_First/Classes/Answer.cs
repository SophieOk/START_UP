using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Code_First
{
   public class Answer
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Text { get; set; }
    }
}
