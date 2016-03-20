using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для Class1
/// </summary>
public class Class1
{
    public static List<int> Comparing(string sphere, List<string> categories, List<string> keying)
    {
        foreach (string key in keying)
            key.ToLowerInvariant();
        List<int> indexes = new List<int>();
        foreach (string key in keying)
        {
            int i = 0;
            var temp = (from item in categories
                        where key == item
                        select  i++ ).ToList();
            indexes.AddRange(temp);
        }
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
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; indexes[j] < maxincat; j++)
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

