using System;
using System.Linq;

public static class Kata
{
    public static object[] ZipIt(this object[] a, object[] b, Func<object, object, object> fn)
    {
        object[] res = new object[a.Length < b.Length ? a.Length : b.Length];
        return res.Select((v,i)=> fn(a[i], b[i])).ToArray();

        // Alternative
        // return a.Zip(b, fn).ToArray();
    }

    public static void Main()
    {
        var a = new object[] { 1, 2, 3, 4, 5 };
        var b = new object[] { 'a','b' };
        Console.WriteLine(string.Join(", ", a.ZipIt(b, (c, d) => c + "" + d)));
    }
}