// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;
public class Kata
{
    public static string FakeBin(string x)
    {
        char[] str = x.ToCharArray();
        string res = "";
        foreach (var item in str)
        {
            int i =(int) char.GetNumericValue(item);
            string s= i < 5 ? "0" : "1";
            res += s;
        }
        return res;

        // Alternative
        // return string.Concat(x.Select(a => a < '5' ? "0" : "1"));
    }
    public static void Main()
    {
        Console.WriteLine(FakeBin("509321967506747"));
    }
}
