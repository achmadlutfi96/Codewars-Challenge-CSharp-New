using System;
public class Kata
{
    public static int IntDiff(int[] arr, int n)
    {
        int res = 0;
        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) == n)
                {
                    res++;
                }
            }
        }
        return res;

        // Alternative 1
        // return arr.Select((x, i) => arr[(i + 1)..].Count(y => Math.Abs(x - y) == n)).Sum();

        // Alternative 2
        // return arr.Select((x,i) => arr.Skip(i+1).Count(y => Math.Abs(x-y) == n)).Sum();
    }

    public static void Main()
    {
        Console.WriteLine(IntDiff(new int[] { 1, 1, 5, 6, 9, 16, 27 }, 4));
        Console.WriteLine(IntDiff(new int[] { 1, 1, 3, 3 }, 0));
    }
}