﻿using CodeFirst.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Context();

            db.SaveChanges();

            Console.ReadKey();

        }
    }
}
