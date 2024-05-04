using System;
using System.Linq;
public class Kata
{
    public static object[] IsVow(object[] a)
    {
        string[] vow = new string[]{"a","i","u","e","o"};
        return a.Select(v => vow.Contains(Convert.ToChar(v).ToString())? Convert.ToChar(v).ToString() : v).ToArray();

        // Alternative
        // return a.Select(x => "aeiou".Contains(Convert.ToChar(x)) ? Convert.ToChar(x).ToString() : x).ToArray();
    }

    public static void Main()
    {
        foreach (var item in IsVow(new object[] { 118,117,120,121,117,98,122,97,120,106,104,116,113,114,113,120,106 }))
        {
            Console.WriteLine(item);
        }
    }
}