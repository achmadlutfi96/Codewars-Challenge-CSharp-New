using System;
using System.Linq;
public class TwoToOne
{

    public static string Longest(string s1, string s2)
    {
        // your code
        return string.Concat(s1.Concat(s2).Distinct().OrderBy(a=>a));

        // Alternative
        // return string.Concat((s1 + s2).Distinct().OrderBy(c => c));
    }

    public static void Main(){
        Console.WriteLine(Longest("aretheyhere", "yestheyarehere"));
    }
}