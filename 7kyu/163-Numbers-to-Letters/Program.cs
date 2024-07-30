using System;
using System.Linq;
public class Kata
{
    public static string Switcher(string[] x)
    {
        // throw new NotImplementedException();
        string y = "zyxwvutsrqponmlkjihgfedcba!? ";
        return string.Concat(x.Select(x=>y[int.Parse(x)-1]));
    }

    public static void Main(){
        Console.WriteLine(Switcher(new string[] { "24", "12", "23", "22", "4", "26", "9", "8" }));
    }
}