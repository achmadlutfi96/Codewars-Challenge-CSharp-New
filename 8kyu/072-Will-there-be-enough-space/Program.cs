// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public static class Kata
{
    public static int Enough(int cap, int on, int wait)
    {
        // throw new NotImplementedException();
        return cap < (on + wait) ? (on + wait) - cap : 0;
        //Alternative
        // return Math.Max(on + wait - cap, 0);
    }
    public static void Main(){
        Console.WriteLine(Enough(100, 60, 50));
        Console.WriteLine(Enough(20, 5, 5));
    }
}
