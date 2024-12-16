using System;
using System.Linq;
public class Kata
{
  public static string Battle(string x, string y)
  {
    // Lets the battle begin!
    float a = x.Sum(v=>char.IsUpper(v) ? (float)v-64 : (float)(v-96)/2);
    float b = y.Sum(v=>char.IsUpper(v) ? (float)v-64 : (float)(v-96)/2);
    return a == b ? "Tie!" : a > b ? x : y;
  }

  public static void Main()
  {
    Console.WriteLine(Battle("One", "Two"));
    Console.WriteLine(Battle("Foo", "BAR"));
  }
}