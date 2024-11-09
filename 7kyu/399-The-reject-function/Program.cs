using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] Reject(int[] array, Func<int, bool> predicate)
    {
        List<int> res = new List<int>();
        foreach (int item in array)
        {
            if(!predicate(item)){
                res.Add(item);
            }
        }
        return res.ToArray();

        // Alternative 1
        // return array.Where(x=>!predicate(x)).ToArray();

        // Alternative 2
        // return Array.FindAll(array, i => !predicate(i));
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Reject(new int[] {1, 2, 3, 4, 5, 6}, (n) => n % 2 == 0)));
    }
}