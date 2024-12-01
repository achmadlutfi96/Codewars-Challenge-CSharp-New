using System;

public class Kata
{
    public static int GetSectionId(int n, int[] a)
    {
        // your code here
        int res = -1;
        int temp = 0;
        for (int i = 0; i < a.Length; i++)
        {
            temp += a[i];
            if(temp > n){
                res = i;
                break;
            }
        }
        return res;

        // Alternative 1
        // return a.Sum() > n ? a.TakeWhile(s => (n -= s) >= 0).Count() : -1;

        // Alternative 2
        // return a.Sum() > n ? a.Count(x => (n -= x) >= 0) : -1;
    }

    public static void Main()
    {
        Console.WriteLine(GetSectionId(300, new int[] { 300, 200, 400, 600, 100 }));
    }
}