using System;
using System.Linq;
public class Kata
{
    public static String[] LineupStudents(String a)
    {
        //code here
        return a.Split(" ").OrderBy(x=>x).OrderBy(x=>x.Length).Reverse().ToArray();

        // Alternative
        // return a.Split().OrderBy(s => -s.Length).ThenByDescending(s => s).ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", LineupStudents("Tadashi Takahiro Takao Takashi Takayuki Takehiko Takeo Takeshi Takeshi")));
    }
}