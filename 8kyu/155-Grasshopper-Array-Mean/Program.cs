using System;
using System.Linq;

public class GrassHopper
{
    public static int FindAverage(int[] nums)
    {
        // your code
        return (int) nums.Average(x => x);
    }
    public static void Main(string[] args){
        Console.WriteLine(FindAverage(new[] { 1, 3, 5, 7 }));
    }
}