using System;
using System.Linq;

public class Kata
{
    public static string FilterNumbers(string str)
    {
        return string.Concat(str.ToCharArray().Where(c => !char.IsDigit(c)));

        // Alternative
        // return new string(str.Where(c => !Char.IsDigit(c)).ToArray());
    }

    public static void Main()
    {
        Console.WriteLine(FilterNumbers("aa1bb2cc3dd"));
    }
}