using System;

public class DivSeven
{
    public static long[] Seven(long m)
    {
        long n = 0;
        // your code
        while (m > 99)
        {
            string s = m.ToString();
            m = (long)int.Parse(s.Substring(0, s.Length - 1)) - (2 * int.Parse(s.Substring(s.Length - 1, 1)));
            n++;
        }
        return new[] { m, n };

        // Alternative
        // int step = 0;

        // while (m > 99)
        // {
        //     m = m / 10 - m % 10 * 2;
        //     step++;
        // }
        // return new long[] { m, step };
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(",", Seven(1603)));
    }
}