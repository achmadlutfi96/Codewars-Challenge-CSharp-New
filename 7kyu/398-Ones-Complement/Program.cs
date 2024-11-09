using System;
using System.Linq;

public static class Kata
{
    public static string OnesComplement(string n)
    {
        // throw new NotImplementedException();
        return string.Concat(n.Select(x=> x == '1' ? '0' : '1'));

        // Alternative
        // return string.Concat(n.Select(c => (char) (c ^ 1)));
    }

    public static void Main()
    {
        Console.WriteLine(OnesComplement("1101"));
    }
}