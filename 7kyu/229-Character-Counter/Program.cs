using System.Linq;
using System;
public class Kata
{
    public static bool ValidateWord(string s)
    {
        //Code goes here!
        if(s == "") return true;
        return s.ToLower().Distinct().Select(x => s.ToLower().Where(y => x == y).Count()).Distinct().Count() == 1;

        // Alternative
        // return s==""?true:s.ToLower().GroupBy(c => c).Select(g => g.Count()).Distinct().Count() == 1;
    }

    public static void Main()
    {
        Console.WriteLine(ValidateWord("Abcabc"));
        Console.WriteLine(ValidateWord("abc123"));
        Console.WriteLine(ValidateWord("abcabcd"));
    }
}