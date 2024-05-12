using System;

public static class Kata
{
  public static double SakuraFall(double v)
  {
    // throw new NotImplementedException();
    return v > 0 ? 400/v : 0;;
  }

  public static void Main(){
    Console.WriteLine(SakuraFall(5));
  }
}