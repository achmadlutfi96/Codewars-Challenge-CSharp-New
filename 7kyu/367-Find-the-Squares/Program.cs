using System;
public class Solution
{
    public static string FindSquares(int n)
    {
        return $"{Math.Pow(Math.Ceiling((double)n/2),2)}-{Math.Pow(Math.Floor((double)n/2),2)}";

        // Alternative
        // return $"{((n + 1) / 2) * ((n + 1) / 2)}-{(n / 2) * (n / 2)}";
    }

    public static void Main()
    {
        Console.WriteLine(FindSquares(9));
        // Console.WriteLine(FindSquares(99991));
    }
}