using System;
using System.Linq;

public class Kata
{
    public static string GeometricSequenceElements(int a, int r, int n)
    {
        // Your code here
        int[] res = new int[n];
        int temp = a;
        for (int i = 0; i < n; i++){
            res[i] = temp;
            temp *= r;
        }
        return string.Join(", ", res);

        // Alternative
        // return string.Join(", ", Enumerable.Range(0, n).Select(i => Math.Pow(r, i) * a));
    }

    public static void Main()
    {
        Console.WriteLine(GeometricSequenceElements(2,3,5));
    }
}