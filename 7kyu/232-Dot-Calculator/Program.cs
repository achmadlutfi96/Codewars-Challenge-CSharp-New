using System;
using System.Linq;
public static class Kata
{
    public static string Calculator(string txt)
    {
        string[] temp = txt.Split(" ");
        int a = temp[0].Length;
        string op = temp[1];
        int b = temp[2].Length;
        int res = 0;
        if (op.Equals("+"))
        {
            res = a + b;
        }

        if (op.Equals("-"))
        {
            res = a - b;
        }

        if (op.Equals("*"))
        {
            res = a * b;
        }

        if (op.Equals("//"))
        {
            res = a / b;
        }
        return string.Concat(Enumerable.Repeat(".", res));

        // Alternative
        // var s = txt.Replace("//", "/").Split();
        // return new string('.', Convert.ToInt32(new DataTable().Compute($"{s[0].Length}{s[1]}{s[2].Length}", null)));
    }
    public static void Main()
    {
        Console.WriteLine(Calculator("..... + ..............."));
    }
}