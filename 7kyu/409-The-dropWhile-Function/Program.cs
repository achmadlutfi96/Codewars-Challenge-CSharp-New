using System;
using System.Linq;

public class Kata
{
    public static int[] DropWhile(int[] arr, Func<int, bool> pred)
    {
        return arr.SkipWhile(pred).ToArray();

        // Alternative
        // int i;
        // for (i = 0; i < arr.Length; i++)
        //     if (!pred(arr[i])) break;
        // return arr[i..];
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", DropWhile(new int[] { 2, 6, 4, 10, 1, 5, 4, 3 }, (value) => value % 2 == 0)));
    }
}