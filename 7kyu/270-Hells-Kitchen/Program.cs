using System;
using System.Linq;
public class Kata
{
    public static string Gordon(string a)
    {
        return string.Join(" ",a.Split(" ").Select(x=> string.Concat(x.ToUpper().Select(y=> y == 'A' ? '@' : y).Select(z=>"IUEO".Contains(z) ? '*' : z ).Concat("!!!!"))));

        // Alternative 1
        // return a.ToUpper().Replace("A", "@").Replace("E", "*").Replace("O", "*").Replace("U", "*").Replace("I", "*").Replace(" ", "!!!! ")+"!!!!";

        // Alternative 2
        // return Regex.Replace(Regex.Replace(a.ToUpper(), @"[EIOU]", "*"), @"\s|$", "!!!!$0").Replace("A", "@");
    }

    public static void Main()
    {
        Console.WriteLine(Gordon("What feck damn cake"));
    }
}