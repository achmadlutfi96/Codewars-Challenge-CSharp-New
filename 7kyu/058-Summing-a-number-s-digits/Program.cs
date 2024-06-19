using System;
using System.Linq;
public class Kata
{
  public static int SumDigits(int number)
  {
    return Math.Abs(number).ToString().Sum(x=>(int)char.GetNumericValue(x));
  }

  public static void Main(){
    Console.WriteLine(SumDigits(99));
  }
}