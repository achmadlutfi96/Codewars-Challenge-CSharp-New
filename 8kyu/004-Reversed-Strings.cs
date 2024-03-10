using System;
using System.Text;
// using System.Linq;

public static class Kata
{
  public static string Solution(string str) 
  {
    // throw new NotImplementedException("TODO: Kata.Solution(string) => string");
    StringBuilder res = new StringBuilder();
    
    for (int i = 0; i < str.Length; i++)
    {
        res.Insert(i, str[str.Length - i -1]);
    }
    return res.ToString();

    // return string.Concat(str.Reverse());
    // return new string(str.ToArray().Reverse().ToArray());
  }
}

class ReversedStrings
{
    public static void Main()
    {
        Console.WriteLine(Kata.Solution("world"));
    }
}