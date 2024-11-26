using System;
using System.Linq;
public class Kata
{
    public static double Geo_Mean(int[] nums, double arith_mean)
    {
        double numLast = arith_mean * (nums.Length+1) - nums.Sum();
        return Math.Pow(nums.Aggregate(1,(a,b)=> a*b) * numLast, (double)1/(nums.Length+1));
    }

    public static void Main()
    {
        Console.WriteLine(Geo_Mean(new int[] {1,2}, 3));
        Console.WriteLine(Geo_Mean(new int[] { 4,6,7,2 }, 5));
    }
}