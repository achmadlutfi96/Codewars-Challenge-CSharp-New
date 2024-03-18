// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
public static class Kata
{
    public static int СenturyFromYear(int year)
    {
        return (int)Math.Ceiling((double)year/100); // up(pembulatan ke atas)

        // Alternative
        // return (year - 1) / 100 + 1;
    }

    public static void Main()
    {
        Console.WriteLine(СenturyFromYear(1705));
    }
}
