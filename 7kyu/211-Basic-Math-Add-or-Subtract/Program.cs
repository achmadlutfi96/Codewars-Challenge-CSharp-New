using System;
using System.Linq;
public static class Kata
{
  public static string Calculate(string str)
  {
    //your code
    return str.Replace("plus", " ").Replace("minus"," -").Split(" ").Select(int.Parse).Sum().ToString();
  }

  public static void Main(){
    Console.WriteLine(Calculate("1plus2plus3plus4"));
  }
}