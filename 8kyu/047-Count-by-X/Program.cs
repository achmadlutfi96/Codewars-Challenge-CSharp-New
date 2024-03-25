// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;

public static class Kata
{
  public static int[] CountBy(int x, int n)
  {
    return Enumerable.Range(x, n*x).Where(i=>i%x==0).ToArray();

    // Alternative
    // return Enumerable.Range(1, n).Select(i => i * x).ToArray(); 
  }
  public static void Main(){
    foreach (var i in CountBy(1,5))
    {
        Console.WriteLine(i);
    }
  }
}
