using System;
using System.Linq;

public class Accumul
{
    public static String Accum(string s)
    {
        // your code
        return string.Join("-",s.Select((x,i) => string.Concat(char.ToUpper(x),string.Concat(Enumerable.Repeat(x,i).ToArray()).ToLower())));

        // Alternative
        // return string.Join("-",s.Select((x,i)=>char.ToUpper(x)+new string(char.ToLower(x),i)));
    }

    public static void Main(){
        Console.WriteLine(Accum("ZpglnRxqenU"));
    }
}