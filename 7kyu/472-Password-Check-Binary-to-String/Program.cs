using System;
using System.Linq;

public static class Kata
{
    public static string? DecodePass(string[] passArr, string bin)
    {
        string res = string.Concat(bin.Split(" ").Select(x=>(char)Convert.ToInt32(x,2)));
        return passArr.Where(x=>res == x).FirstOrDefault();

        // Alternative 
        // var binStr = string.Concat(bin.Split().Select(x => (char)Convert.ToInt32(x, 2)));
        // return passArr.Contains(binStr) ? binStr : null;
    }

    public static void Main()
    {
        Console.WriteLine(DecodePass(new string[] { "password123", "admin", "admin1" },
                "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011"));
        Console.WriteLine(DecodePass(new string[] { "password321", "admin", "admin1" },
                "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011"));
    }
}