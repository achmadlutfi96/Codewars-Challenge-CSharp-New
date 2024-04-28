using System;

public class Numbers
{
  public static double TwoDecimalPlaces(double number)
  {
    //Write your code here
    return Math.Round(number,2);
  }

  public static void Main(){
    Console.WriteLine(TwoDecimalPlaces(4.659725356));
  }
}