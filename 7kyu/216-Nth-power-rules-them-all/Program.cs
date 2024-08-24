using System;
using System.Linq;
public class Kata
{
  public static int ModifiedSum(int[] a, int n)
  {
    // Write your code here
    return (int) (a.Select(x=>Math.Pow(x,n)).Sum() - a.Sum());

    // Alternative
    // return a.Sum(x => (int) Math.Pow(x, n) - x);
  }

  public static void Main(){
    Console.WriteLine(ModifiedSum(new int[] {1, 2, 3}, 3));
  }
}