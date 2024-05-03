using System;
using System.Linq;

public static class Kata 
{
  public static string[] Websites = Enumerable.Repeat("codewars", 1000).ToArray();


  public static void Main(){
    foreach (var item in Websites)
    {
        Console.WriteLine(item);
    }
  }
}
