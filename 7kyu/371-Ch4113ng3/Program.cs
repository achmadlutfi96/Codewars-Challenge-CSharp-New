using System;
using System.Linq;

public static class Kata
{
    public static string Nerdify(string str)
    {
        // throw new NotImplementedException();
        return string.Concat(str.Select(x => char.ToLower(x) == 'a' ? '4' : char.ToLower(x) == 'e' ? '3' : x == 'l' ? '1' : x));

        // Alternative 1
        // return Regex.Replace(str, "[aelAE]", m => $"{"43143"["aelAE".IndexOf(m.Value[0])]}");

        // Alternative 2
        // if (str == null)
        // {
        //     throw new ArgumentNullException();
        // }
        // return str.Replace('a', '4')
        //     .Replace('A', '4')
        //     .Replace('e', '3')
        //     .Replace('E', '3')
        //     .Replace('l', '1');
    }

    public static void Main()
    {
        Console.WriteLine(Nerdify("Seoijselawuue"));
    }
}