using System;

public static class Kata
{
    public static long ReverseBits(long n)
    {
        return Convert.ToInt64(string.Concat(Convert.ToString(n, 2).Reverse()),2);

        // Alternative
        // long m = 0;
        // while (n > 0)
        // {
        //     m <<= 1;
        //     if (n % 2 == 1) m ^= 1;
        //     n >>= 1;
        // }
        // return m;
    }

    public static void Main(){
        Console.WriteLine(ReverseBits(417) == 267);
    }
}