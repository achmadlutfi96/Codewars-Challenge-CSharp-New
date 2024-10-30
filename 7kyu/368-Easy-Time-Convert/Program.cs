using System;

public static class Kata
{
  public static string TimeConvert(int num)
  {
    // throw new NotImplementedException();
    return num > 0 ? $"{num/60:d2}:{num%60:d2}" : "00:00";
  }

  public static void Main(){
    Console.WriteLine(TimeConvert(75));
    Console.WriteLine(TimeConvert(32));
    Console.WriteLine(TimeConvert(565757));
  }
}