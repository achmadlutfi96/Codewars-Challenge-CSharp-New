// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;
public class Kata
{
    public static int[] SquareOrSquareRoot(int[] array)
    {
        return Array.ConvertAll(array.Select(i => (int) Math.Pow(Math.Floor(Math.Sqrt(i)),2) == i ?  Math.Sqrt(i) : i*i).ToArray(), new Converter<double, int>(a => (int)a));

        // Alternative
        // return array.Select(x => (int)(Math.Sqrt(x) % 1 == 0 ? Math.Sqrt(x) : x * x)).ToArray();
    }

    public static void Main()
    {
        foreach (var item in SquareOrSquareRoot(new int[] { 4, 3, 9, 7, 2, 1 }))
        {
            Console.WriteLine(item);
        }
    }
}
