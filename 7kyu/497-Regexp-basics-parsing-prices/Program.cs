using System;
using System.Globalization;
using System.Text.RegularExpressions;

public static class Kata
{
    public static int? ToCents(this string price)
    {
        var s = Regex.Replace(Regex.Match(price, @"^\$\d{1,}\.\d{2}\z").Value, @"(\.|\$)", "");
        return s.Any() ? int.Parse(s) : (int?) null;
    }

    public static void Main()
    {
        Console.WriteLine(ToCents("$12345678.90"));
    }
}