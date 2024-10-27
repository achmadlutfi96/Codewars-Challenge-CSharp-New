using System;
public class Triangular
{
    public static bool isTriangular(int T)
    {
        // Good Luck ;)
        if (T < 0 || T > 2147483646)
        {
            return false;
        }

        // A Triangular number must be sum of first n
        // natural numbers
        long sum = 0;
        for (int n = 1; sum <= T; n++)
        {
            sum = sum + n;
            if (sum == T)
                return true;
        }

        return false;

        // Alternative 1
        // return Math.Sqrt(8L * T + 1) % 1 == 0;

        // Alternative 2
        // int i = 1;
        // while (T > 0) T -= i++;
        // return (T == 0);

    }

    public static void Main()
    {
        Console.WriteLine(isTriangular(6));
        Console.WriteLine(isTriangular(7));
        Console.WriteLine(isTriangular(27));
        Console.WriteLine(isTriangular(21));
        Console.WriteLine(isTriangular(2147483646));
    }
}