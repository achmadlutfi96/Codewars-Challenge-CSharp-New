// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;
using System;
public class Kata
{
  public static int SumMix(object[] x)
  {
    return x.Select(i=> Convert.ToInt32(i)).Sum();
    // Alternative
    // return x.Sum(ToInt32);
  }
  public static void Main(){
    Console.WriteLine(SumMix(new object[] {9, 3, "7", "3"}));
  }
}
