using System;
using System.Linq;

public static class Kata
{
    public static bool IsAllPossibilities(int[] arr)
    {
        Array.Sort(arr);
        return Enumerable.Range(0, arr.Length).Select((v,i)=>v == arr[i]).All(x=>x==true);

        // Alternative
        // return arr.Any() && Enumerable.Range(0, arr.Length).All(arr.Contains);
    }

    public static void Main(){
        Console.WriteLine(IsAllPossibilities(new int[] {0, 1, 2, 3}));
        Console.WriteLine(IsAllPossibilities(new int[] {1, 2, 3, 4}));
    }
}