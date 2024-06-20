using System;
using System.Linq;
class Kata
{
    public static long MinValue(int[] a)
    {
        //Magic
        return Convert.ToInt64(string.Concat(a.OrderBy(x=>x).DistinctBy(x=>x).ToArray()));

        // Alternative
        //  return long.Parse(string.Concat(a.Distinct().OrderBy(x => x)));
    }

    public static void Main(){
        Console.WriteLine(MinValue(new int[]{ 3, 6, 5, 5, 9, 8, 7, 6, 3, 5, 9}));
    }
}