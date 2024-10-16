using System;

public class Kata
{
    public static string Search(int budget, int[] prices)
    {
        // return array pf prices that are within budget
        return string.Join(",",prices.OrderBy(x=>x).Where(x=>budget>=x));
    }

    public static void Main()
    {
        Console.WriteLine(Search(14, new int[]{7,3,23,9,14,20,7}));
    }
}