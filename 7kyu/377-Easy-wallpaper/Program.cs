using System;
using System.Collections.Generic;

public class Wallpaper
{
    public static string WallPaper(double l, double w, double h)
    {
        string[] numbers = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };
        if (l == 0 || w == 0 || h == 0) return numbers[0];
        int rolls = (int)Math.Ceiling(((2 * (l * h)) + (2 * (w * h)) + (((2 * (l * h)) + (2 * (w * h))) * 0.15)) / (0.52 * 10));
        return numbers[rolls];

        // Alternative
        // return l == 0 || w == 0 || h == 0
        // ? "zero"
        // : new[]
        // {
        //     "zero", "one", "two", "three", "four", "five", "six", "seven",
        //     "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen",
        //     "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"
        // }[(int) Math.Ceiling((l + w) * 2.3 * h / 5.2)];
    }

    public static void Main()
    {
        Console.WriteLine(WallPaper(4.0, 3.5, 3.0));
    }
}