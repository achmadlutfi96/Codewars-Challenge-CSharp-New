using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Kata
{
    public static bool HexNumber(this string s)
    {
        if("0\n" == s) return false;
        return Regex.IsMatch(s , @"^(0[xX])?[0-9a-fA-F]+$");

        // Alternative
        // return Regex.IsMatch(s, @"^(0x)?[A-Fa-f\d]+\z");
    }
}