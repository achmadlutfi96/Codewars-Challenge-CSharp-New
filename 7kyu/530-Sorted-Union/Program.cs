using System;
using System.Linq;
public class Kata
{
    public static object[] UniteUnique(object[][] array)
    {
        return array.Aggregate((x,y)=> x.Concat(y).ToArray()).Distinct().ToArray();

        // Alternative
        // return array.SelectMany(x=>x).Distinct().ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ",UniteUnique(new [] { new object[] { 1, 3, 2 }, new object[] { 5, 2, 1, 4 }, new object[] { 2, 1 } })));
    }
}