// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;
public class Kata
{
  public static string DoubleChar(string s)
  {
    // your code here
    string res = "";
    foreach (var i in s)
    {
        res = res+i+i;
    }
    return res;
    // Alternative
    // return string.Concat(s.Select(x => $"{x}{x}"));
    // return string.Join("", s.Select(x => "" + x + x));
  }
  public static void Main(){
    Console.WriteLine(DoubleChar("abcd"));
  }
}
