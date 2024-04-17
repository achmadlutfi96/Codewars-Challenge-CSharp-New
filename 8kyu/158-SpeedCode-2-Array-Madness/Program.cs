using System.Linq;
using System;
public class Kata
{
  public static bool ArrayMadness(int[] a, int[] b)
  {
    // Ready, get, set, GO!!!
    return a.Select(i=>Math.Pow(i, 2)).Sum() > b.Select(i=>Math.Pow(i, 3)).Sum();

    // Alternative
    // return a.Sum(n => n * n) > b.Sum(n => n * n * n);
  }
  public static void Main(){
    Console.WriteLine(ArrayMadness(new int[] {4, 5, 6}, new int[] {1, 2, 3}));
  }
}