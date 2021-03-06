﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Methods
    {
        delegate List<string> del(string a);
        public static List<string> Keying(string description)
        {

            del Kying = x => x.Split(new char[] { ' ', '!', '\'', '.', ';', '(', ')', '+', '=', '*', '/', '?', '#', '№' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            return Kying(description);
        }
        public static List<int> Comparing(string sphere, List<string> categories, List<string> keying)
        {
            foreach (string key in keying)
                key.ToLowerInvariant();

            List<int> indexes = new List<int>();
            /*int cat = 0;
            for (int i = 0; i < db.GetLength(0); i++)
            {
                if (category == db[0, i])
                {
                    cat = i;
                    break;
                }
            }*/
            foreach (string key in keying)
            {
                int i = 0;
                var temp = (from item in categories//поменять двумерный массив на список
                            where key == item
                            select new { Index = i++}).ToList();

                //indexes.AddRange(temp);
            }
            /*foreach (string i in keying)
            {
                for (int j = 0; j < db.GetLength(1); j++)
                {
                    if (i == db[j, cat])
                    {
                        indexes.Add(j);
                        break;
                    }
                }
            }*/
            indexes.Sort();
            return indexes;
        }
        public static string Answer(List<int> indexes, List<string> answers)
        {
            string final = null;
            int maxincat = 10;
            int curmax = 0;
            int fincat = 0;
            int catmax = 0;
            for (int i = 0; i<10; i++)
            {
                for (int j = 0; indexes[j]<maxincat; j++)
                {
                    curmax++;
                }
                maxincat = +10;
                if (curmax >= catmax)
                {
                    catmax = curmax;
                    fincat = i;
                }
            }
            final = answers[fincat];
            return final;
        }
    }
}
