using System;
using System.Linq;

public static class Kata
{
    public static int MobileKeyboard(string str)
    {
        string[] mKeyboard = new string[] { "1", "2abc", "3def", "4ghi", "5jkl", "6mno", "7pqrs", "8tuv", "9wxyz","*","0","#"};
        return str.Select(x=>mKeyboard.Where(y=>y.Contains(x)).First().IndexOf(x)+1).Sum();
    }

    public static void Main()
    {
        Console.WriteLine(MobileKeyboard("thisisasms"));
    }
}