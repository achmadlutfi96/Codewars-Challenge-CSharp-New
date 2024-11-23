using System;
using System.Numerics;

public class Easyline
{
    public static BigInteger EasyLine(int n)
    {
        // your code
        BigInteger sum = 1;
        for (var i = 1; i <= n; i++)
        {
            sum = sum * (n + i) / i;
        }

        return sum;
    }

    public static void Main()
    {
        Console.WriteLine(EasyLine(4));
    }
}