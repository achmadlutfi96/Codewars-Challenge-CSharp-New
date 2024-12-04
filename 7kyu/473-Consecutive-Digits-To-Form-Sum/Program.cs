using System;

public class Kata
{
    public static bool ConsecutiveDucks(int n)
    {
        // your code here
        for (int k = 2; k * (k - 1) / 2 < n; k++) { 
            if ((n - k * (k - 1) / 2) % k == 0) { 
                return true; 
            } 
        }
        return false;

        // Alternative 1
        // return (n-- & n) != 0;

        // Alternative 2
        // return Math.Log2(n) % 1 != 0;
    }

    public static void Main()
    {
        Console.WriteLine(ConsecutiveDucks(69));
        Console.WriteLine(ConsecutiveDucks(16));
    }
}