using System;
using System.Linq;

public class Kata
{
    public static bool IsAscOrder(int[] arr)
    { /* your code here */
        int[] asc = new int[arr.Length];
        Array.Copy(arr, asc, arr.Length);
        Array.Sort(asc);
        return arr.Select((x, i) => x == asc[i]).All(x => x == true);

        // Alternative 1
        // for (int i = 1; i<arr.Length; i++)
        // 	if (arr[i-1] > arr[i]) return false;
        // return true;

        // Alternative 2
        // return arr.SequenceEqual(arr.OrderBy(x=>x));

        // Alternative 3
        // return arr.OrderBy(x => x).SequenceEqual(arr);
    }

    public static void Main()
    {
        Console.WriteLine(IsAscOrder(new int[] { 2, 1, 3 }));
        Console.WriteLine(IsAscOrder(new int[] { 1, 2, 3 }));
    }
}