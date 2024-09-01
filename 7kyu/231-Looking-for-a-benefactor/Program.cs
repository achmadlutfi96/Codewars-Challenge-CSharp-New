using System;
using System.Linq;
public class NewAverage
{
    public static long NewAvg(double[] arr, double navg)
    {
        // your code
        long result = (long)Math.Ceiling((navg - (arr.Sum() / (arr.Length + 1))) * (arr.Length + 1));
        return result > 0 ? result : throw new ArgumentException();

        // Alternative
        //     var don = (arr.Length + 1) * navg - arr.Sum();
        // return don > 0 ? (long) Math.Ceiling(don) : throw new ArgumentException(); 
    }

    public static void Main()
    {
        Console.WriteLine(NewAvg(new double[] { 14, 30, 5, 7, 9, 11, 15 }, 100));
    }
}