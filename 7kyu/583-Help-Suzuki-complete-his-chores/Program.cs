using System;
using System.Linq;
public class Kata
{
    public static int[] ChoreAssignment(int[] chores)
    {
        //code here
        int[] a = chores.Order().Take(chores.Length / 2).ToArray();
        int[] b = chores.OrderDescending().Take(chores.Length / 2).ToArray();

        return a.Select((v,i) => v+b[i]).Order().ToArray();

        // Alternative
        // int[] arr = chores.OrderBy(x => x).ToArray();
        // return arr.Take(arr.Length / 2)
            //   .Select((x, i) => x + arr[arr.Length - 1 - i])
            //   .OrderBy(x => x)
            //   .ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", ChoreAssignment(new[] { 5, 2, 1, 6, 4, 4 })));
        Console.WriteLine(string.Join(", ", ChoreAssignment(new [] {1, 5, 2, 8, 4, 9, 6, 4, 2, 2, 2, 9})));
    }
}