using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CodeFirst.Model
{
   public class Answer
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Text { get; set; }
        
    }
}
