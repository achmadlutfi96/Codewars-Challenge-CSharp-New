using System;
using System.Linq;

public static class Kata
{
    public static string SillyCase(string str)
    {
        // throw new NotImplementedException();
        return string.Concat(str.Select((v, i) => i + 1 <= Math.Ceiling((double)str.Length / 2) ? char.ToLower(v) : char.ToUpper(v)));

        // Alternative
        // int half = (str.Length + 1) / 2;
        // return str[..half].ToLower() + str[half..].ToUpper();
    }

    public static void Main()
    {
        Console.WriteLine(SillyCase("codewars"));
        Console.WriteLine(SillyCase("brian"));
    }
}