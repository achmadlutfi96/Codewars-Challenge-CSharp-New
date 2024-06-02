using System;
using System.Linq;

public class Kata
{
  public static int SquareDigits(int n)
  {
    return Convert.ToInt32(string.Concat(n.ToString().Select(i=>Math.Pow(Char.GetNumericValue(i),2).ToString())));
  }

  public static void Main(){
    Console.WriteLine(SquareDigits(9119));
  }
}