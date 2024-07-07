using System;
using System.Linq;

public class Solution
{
    public static int[] solve(int[] arr)
    {
        //..      

        return arr.Reverse().Distinct().Reverse().ToArray();
    }

    public static void Main()
    {
        foreach (var item in solve(new int[] { 3, 4, 4, 3, 6, 3 }))
        {
            Console.WriteLine(item);
        }
    }
}