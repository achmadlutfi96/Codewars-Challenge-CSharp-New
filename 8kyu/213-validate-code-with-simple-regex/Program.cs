using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static bool ValidateCode(string code)
    {
        //use regex here
        return Regex.IsMatch(code, @"^[1-3]");
    }

    public static void Main()
    {
        Console.WriteLine(ValidateCode("248"));
    }
}