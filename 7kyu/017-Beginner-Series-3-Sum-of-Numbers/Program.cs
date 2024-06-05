using System;
using System.Linq;
public class Sum
{
    public static int GetSum(int a, int b)
    {
        //Good Luck!
        int res = 0;
        if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                res += i;
            }
        }
        else if (a == b)
        {
            res = a;
        }
        else
        {
            for (int i = b; i <= a; i++)
            {
                res += i;
            }
        }
        return res;

        // Alternative 1
        // return (a + b) * (Math.Abs(a - b) + 1) / 2;
        // Alternative 2
        // return Enumerable.Range(Math.Min(a,b), Math.Max(b,a)-Math.Min(b,a)+1).Sum();

    }

    public static void Main()
    {
        Console.WriteLine(GetSum(1, 2));
    }
}