using System;

public class Solution
{
    public static (int, int) solve(int a, int b)
    {
        //.. 
        if (a == 0 || b == 0)
        {
            return (a, b);
        }
        else
        {
            if (a >= 2 * b)
            {
                int temp = a - (2 * b);
                return solve(temp, b);
            }
            else
            {
                if (b >= 2 * a)
                {
                    int temp = b - (2 * a);
                    return solve(a, temp);
                }
                else
                {
                    return (a, b);
                }
            }
        }

        // Alternative 
        // return 0 == a || 0 == b ? (a, b) :
        // a >= 2 * b ? solve(a - 2 * b, b) :
        // b >= 2 * a ? solve(a, b - 2 * a) : (a, b);
    }

    public static void Main()
    {
        Console.WriteLine(string.Concat(solve(6, 19)));
        Console.WriteLine(string.Concat(solve(22, 5)));
        Console.WriteLine(string.Concat(solve(8796203, 7556)));
    }
}
