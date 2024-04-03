using System;
using System.Linq;
using System.Collections.Generic;
public class Kata
{
    public static int ExpressionsMatter(int a, int b, int c)
    {
        // Your Code here... Happy Coding!
        List<int> val = new List<int>();
        val.Add(a * (b + c));
        val.Add(a * b * c);
        val.Add(a + b * c);
        val.Add((a + b) * c);
        val.Add(a + b + c);

        return val.Max();// highest achievable result

        // Alternative
        // int[] res =
    // {
    //  a*b*c,
    //  a*b+c,
    //  a*(b+c),
    //  (a+b)*c,
    //  a+b*c,
    //  a+b+c
    //  };
    //     return res.Max();
    }
    public static void Main()
    {
        Console.WriteLine(ExpressionsMatter(1, 2, 3));
    }
}