using System;
using System.Linq;
class Kata
{
    public static string Solve(string s)
    {
        //Do Some Magic
        return s.Where(x=>char.IsLower(x)).Count() >= s.Where(x=>char.IsUpper(x)).Count() ? s.ToLower() : s.ToUpper();

        // Alternative
        // return s.Count(char.IsUpper) > s.Count(char.IsLower) ? s.ToUpper() : s.ToLower();
    }

    public static void Main(){
        Console.WriteLine(Solve("CODe"));
    }
}