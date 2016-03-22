using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirst.Classes;

namespace CodeFirst
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public virtual Category Category { get; set; }
    }
}
