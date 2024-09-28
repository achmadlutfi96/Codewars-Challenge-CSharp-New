using System;

public class Kata
{
    public static string Change(string input)
    {
        // ...
        return String.Concat("abcdefghijklmnopqrstuvwxyz".Select(x=> input.ToLower().Contains(x) ? '1': '0'));

        // Alternative
        // return string.Concat(Enumerable.Range('a', 26).Select(i => input.ToLower().Contains((char) i) ? 1 : 0));
    }

    public static void Main()
    {
        Console.WriteLine(Change("a **&  bZ"));
    }
}