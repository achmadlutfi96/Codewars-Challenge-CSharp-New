using System;
using System.Linq;
public class Kata
{
    public static bool IsMonotone(int[] arr)
    {
        // TODO
        return arr.OrderBy(x=>x).SequenceEqual(arr);
    }

    public static void Main()
    {
        Console.WriteLine(IsMonotone(new int[] {1, 2, 3, 3, 4, 5}));
        Console.WriteLine(IsMonotone(Enumerable.Range(1, 5).Reverse().ToArray()));
        Console.WriteLine(IsMonotone(new int[] {}));
    }
}