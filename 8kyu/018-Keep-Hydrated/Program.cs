// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Kata
{
  public static int Litres(double time)
  {
    //The fun begins here.
    return Convert.ToInt32(Math.Floor(time*0.5));
  }

  public static void Main(){
    Console.WriteLine(Litres(12.3));
  }
}
