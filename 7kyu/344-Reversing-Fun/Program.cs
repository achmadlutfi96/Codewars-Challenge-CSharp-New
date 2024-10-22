using System;
using System.Linq;

public class Kata
{
    public static string FlipNumber(string n)
    {
        //Code goes here!
        string res = "";
        string temp = n;
        for (int i = 0; i < n.Length; i++)
        {
            temp = string.Concat(temp.Reverse());
            res += temp.First();
            temp = temp.Substring(1);
        }
        return res;

        // Alternative 1
        // return Enumerable.Range(0, n.Length - 1).Select((x, i) => n = n[..i] + string.Concat(n[i..].Reverse())).Last();

        // Alternative 2
        // return $"{n.Last()}{(n.Length > 1 ? FlipNumber(string.Concat(n[..^1].Reverse())) : "")}";

    }

    public static void Main(){
        Console.WriteLine(FlipNumber("0123456789"));
    }
}