using System;
using System.Linq;
public class Scaling
{
    public static string Scale(string strng, int k, int n) 
    {
        // your code
        if(strng.Length == 0) { return string.Empty; }
        var newString = strng.Split("\n").Select(x => string.Join("\n",Enumerable.Repeat(string.Concat(x.Select(y=>string.Concat(Enumerable.Repeat(y, k)))), n)));        
        return string.Join("\n", newString);

        // Alternative
        // return string.Join('\n', s.Split('\n').Select(x => x.Any()
        // ? string.Join('\n', Enumerable.Repeat(string.Concat(x.Select(c => new string(c, k))), n))
        // : ""));
    }

    public static void Main(){
        Console.WriteLine(Scale("abcd\nefgh\nijkl\nmnop", 2, 3));
    }
}