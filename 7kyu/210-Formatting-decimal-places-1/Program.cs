using System;
using System.Text;

public class Numbers
{
  public static double TwoDecimalPlaces(double number)
  {
    //Write your code here
    return Math.Round(number, 2, MidpointRounding.ToZero);

    // Alternative
    // return Math.Truncate(number * 100.0) / 100.0;
  }

  public static void Main(){
    Console.WriteLine(TwoDecimalPlaces(10.1289767789));
  }
}