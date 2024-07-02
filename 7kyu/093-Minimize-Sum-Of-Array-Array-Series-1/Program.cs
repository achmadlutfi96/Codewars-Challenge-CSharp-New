using System;
using System.Linq;

class Kata
{
    public static int MinSum(int[] a)
    {
        //Do Some Magic
        Array.Sort(a);
        int[] a1 = a.Take(a.Length/2).ToArray();
        int[] a2 = a.Reverse().Take(a.Length/2).ToArray();
        return a1.Select((v,i) => v*a2[i]).Sum();

        // Alternative
        // return a.OrderBy(n => n).Skip(a.Length / 2).Zip(a.OrderByDescending(n => n).Skip(a.Length / 2), (x, y) => x * y).Sum();
    }

    public static void Main(){
        Console.WriteLine(MinSum([5, 4, 2, 3]));
    }
}