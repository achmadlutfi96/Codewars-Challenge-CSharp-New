using System;
using System.Text.RegularExpressions;

public static class Kata
{
    public static int Solve(string s)
    {
        // throw new NotImplementedException();
        return Regex.Split(s, "[a-zA-Z]").Where(x=>x.Length>0).Select(int.Parse).Max(x=>x);

        // Alternative
        // return Regex.Matches(s, @"\d+").Max(x => int.Parse(x.Value));
    }

    public static void Main()
    {
        Console.WriteLine(Solve("gh12cdy695m1"));
        Console.WriteLine(Solve("2ti9iei7qhr5"));
    }
}