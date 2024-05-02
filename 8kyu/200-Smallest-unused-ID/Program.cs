using System;
using System.Linq;

public class Kata
{
    public static int NextId(int[] ids)
    {
        //this will be awesome!
        var x = 0;
        while (ids.Contains(x)) x++;
        return x;

        // ALternative
        // return Enumerable.Range(0,ids.Length+1).Except(ids).Min();
    }

    public static void Main()
    {
        Console.WriteLine(NextId(new int[] { 9, 9, 8 }));
    }
}