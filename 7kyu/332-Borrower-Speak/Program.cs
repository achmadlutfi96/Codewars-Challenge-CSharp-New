using System;
using System.Linq;
public class Kata
{
    public static string Borrow(string s)
    {
        return string.Concat(s.Where(char.IsLetter).Select(char.ToLower));

        // Alternative
        // return string.Concat(s.ToLower().Where(c => c >= 'a' && c <= 'z'));
    }

    public static void Main()
    {
        Console.WriteLine(Borrow("WhAt! FiCK! DaMn CAke?"));
    }
}