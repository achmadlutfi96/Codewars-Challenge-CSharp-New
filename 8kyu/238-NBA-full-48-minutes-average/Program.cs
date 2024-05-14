using System;
public class Kata
{
  public static double NbaExtrap(double ppg, double mpg)
  {
    // return double.PositiveInfinity;
    return ppg == 0 || mpg == 0 ? 0 : Math.Round((48/mpg)*ppg, 1);
  }

  public static void Main(){
    Console.WriteLine(NbaExtrap(12, 20));
  }
}