using System;

public class Kata
{
  public static double CalculateTotal(double subtotal, int tax, int tip)
  {
    // TODO: your solution here
    return Math.Round(subtotal + (subtotal*tax/100) + (subtotal*tip/100) ,2);
  }

  public static void Main(){
    Console.WriteLine(CalculateTotal(5.00, 5, 10));
  }
}