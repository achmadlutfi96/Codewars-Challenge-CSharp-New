using System;
using System.Linq;
public static class Kata
{
    public static double add(double x)
    {
        return x + 1;
    }

    public static double mul(double x)
    {
        return x * 30;
    }

    public static double Chain(double input, Func<double, double>[] fs)
    {
        // your code ...
        double result = input;
        foreach (var item in fs)
        {
            result = item(result);
        }
        return result;

        // Alternative 1
        // foreach (var func in fs) input = func(input);
        // return input;

        // Alternative 2
        // return fs.Aggregate(input, (current, t) => t(current));
    }

    public static void Main()
    {
        Console.WriteLine(Chain(2, new[] { (Func<double, double>)add, mul }));
    }
}