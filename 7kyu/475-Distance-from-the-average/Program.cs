using System;
using System.Linq;
public class Kata
{
    public static double[] DistancesFromAverage(int[] input)
    {
        //your code here
        double average = input.Average();
        return input.Select(x=>Math.Round(average-x,2)).ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ",DistancesFromAverage(new[] { 55, 95, 62, 36, 48 })));
    }
}