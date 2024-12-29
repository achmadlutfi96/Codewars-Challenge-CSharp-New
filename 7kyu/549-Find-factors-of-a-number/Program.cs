using System;
using System.Linq;

public class Kata
{
  public static int[] Factors(int num)
  {
    // return array of factors
    return num > 0 ? Enumerable.Range(1,num).Where(x=>num%x == 0).Reverse().ToArray() : new int[0];
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(", ", Factors(54)));
  }
}