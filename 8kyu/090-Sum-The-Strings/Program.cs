// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Solution
{
  public static class Program
  {
    public static string StringsSum(string s1, string s2)
    {
      // Write your solution here.
      return (Int32.Parse(String.IsNullOrEmpty(s1) ? "0" : s1) + Int32.Parse(String.IsNullOrEmpty(s2) ? "0" : s2)).ToString();
      // Alternative
      // return $"{(s1 == "" ? 0 : int.Parse(s1)) + (s2 == "" ? 0 : int.Parse(s2))}";
    }
    public static void Main(){
        Console.WriteLine(StringsSum("4","5"));
        Console.WriteLine(StringsSum("",""));
        Console.WriteLine(StringsSum("9",""));
    }
  }
}
