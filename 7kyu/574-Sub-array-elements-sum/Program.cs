using System;
class Kata
{
    public static int ElementsSum(int[][] arr, int d = 0)
    {
        return arr.Select((v,i)=> v.Length > arr.Length-i-1 ? v[arr.Length-i-1]: d).Sum();
    }

    public static void Main()
    {
        Console.WriteLine(ElementsSum(new[] { new[] { 3, 2, 1, 0 }, new[] { 4, 6, 5, 3, 2 }, new[] { 9, 8, 7, 4 } }));
    }
}