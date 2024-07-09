using System;
using System.Linq;

public static class Kata
{
    public static int palindromeChainLength(int n)
    {
        int step = 0;
        long sum = n;
        while (sum != long.Parse(string.Concat(sum.ToString().Reverse())))
        {
            sum += long.Parse(string.Concat(sum.ToString().Reverse()));
            step++;
        }

        return step;

        // Alternative 1
        // int r = int.Parse(n.ToString().Reverse().Aggregate("", (s,c) => s+c));
        // return (n == r) ? 0 : (1 + palindromeChainLength(r+n));

        // Alternative 2
        // var reversed = ulong.Parse(string.Concat($"{n}".Reverse()));
        // return reversed == n ? 0 : 1 + palindromeChainLength(n + reversed);
    }

    public static void Main()
    {
        Console.WriteLine(palindromeChainLength(87));
    }
}