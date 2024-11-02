using System;
using System.Linq;

public class Solution
{
    public static String solve(int n)
    {
        //..
        string res = "";
        string t1 = "0";
        string t2 = "1";
        int i = -1;
        while (i < n)
        {
            res += t1;
            t1 = t2;
            t2 = res;
            i++;
        }
        return res;

        // Alternative
        // if (n == 0)
        // {
        //     return "0";
        // }
        // if (n == 1)
        // {
        //     return "01";
        // }
        // return solve(n - 1) + solve(n - 2);
    }

    public static void Main()
    {
        Console.WriteLine(solve(3));
        Console.WriteLine(solve(5));
    }
}