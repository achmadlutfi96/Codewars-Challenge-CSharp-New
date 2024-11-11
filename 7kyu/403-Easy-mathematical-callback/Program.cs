using System;

public class Kata
{
    public static int[] ProcessArray(int[] arr, Func<int, int> callback)
    {
        // TODO
        int[] res = new int[arr.Length];
        for(int i = 0; i < arr.Length; i++){
            res[i] = callback(arr[i]);
        }
        return res;

        // Alternative 
        // return arr.Select(callback).ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ",ProcessArray(new int[] {4, 8, 2, 7, 5}, (Func<int, int>)((v) => v * 2))));
    }
}