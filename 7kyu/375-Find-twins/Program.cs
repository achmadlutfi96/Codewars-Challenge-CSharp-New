using System;
using System.Linq;
public class Kata
{
    public static object? Elimination(int[] arr)
    {
        return arr.Distinct().Count() == arr.Length ? "null" : arr.Distinct().Where(x=>arr.Count(y=>x==y) == 2).First();

        // Alternative 
        // return arr.GroupBy(i => i).FirstOrDefault(g => g.Count() == 2)?.Key;
    }

    public static void Main()
    {
        Console.WriteLine(Elimination(new int[] {2, 2, 34, 1, 22}));
        Console.WriteLine(Elimination(new int[] {2, 5, 34, 1, 22}));
    }
}