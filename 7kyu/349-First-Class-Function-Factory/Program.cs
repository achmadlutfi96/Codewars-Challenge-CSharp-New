using System;
using System.Linq;
public class FunctionFactory
{
    public static Func<int[], int[]> factory(int x)
    {
        // Good Luck!
        return y => y.Select(z=>z*x).ToArray();
    }

    public static void Main()
    {
        Func<int[], int[]> threes = FunctionFactory.factory(3);
        int[] myArr = new int[] { 1, 2, 3 };
        Console.WriteLine(string.Join(",", threes(myArr)));
    }
}