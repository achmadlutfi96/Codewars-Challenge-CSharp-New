using System;
using System.Linq;

public class Kata
{
    public static string[][] search_names(string[][] logins)
    {
        // your code
        return logins.Where(x=> x[0].EndsWith("_")).ToArray();
    }

    public static void Main(){
        string[][] a = { new[] { "foo", "foo@foo.com" }, new[] { "bar_", "bar@bar.com" } };
        Console.WriteLine(search_names(a));
    }
}