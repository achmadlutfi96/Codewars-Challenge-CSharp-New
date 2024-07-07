using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static int Repeats(List<int> source)
    {
        // throw new NotImplementedException();
        return source.Distinct().Where(x=>source.Where(i=>i==x).Count()==1).Sum();

        // Alternative 1
        // return source.GroupBy(x => x).Where(x => x.Count() == 1).Sum(x => x.Key);
        // Alternative 2
        // return source.Sum(x => source.Count(i => i == x) < 2 ? x : 0);
    }

    public static void Main()
    {
        Console.WriteLine(Repeats(new List<int> { 4, 5, 7, 5, 4, 8 }));
    }
}