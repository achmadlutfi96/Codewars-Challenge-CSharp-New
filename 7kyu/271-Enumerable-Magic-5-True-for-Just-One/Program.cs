using System;

public class Kata
{
    public static bool One(int[] arr, Func<int, bool> fun)
    {
        return arr.Select(fun).Where(x=>x==true).Count() == 1;

        // Alternative
        // return arr.Count(fun) == 1;
    }

    public static void Main()
    {
        Console.WriteLine(One(new int[] { 1,2,3,4,5 }, v => v < 2));
    }
}