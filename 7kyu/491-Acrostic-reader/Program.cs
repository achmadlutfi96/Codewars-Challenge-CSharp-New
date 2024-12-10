using System;
using System.Linq;

public static class Kata
{
  public static string ReadOut(string[] acrostic)
  {
    // throw new NotImplementedException();
    return string.Concat(acrostic.Select(x=>x[0]));
  }

  public static void Main()
  {
    Console.WriteLine(ReadOut(new string[] {"Jolly", "Amazing", "Courteous", "Keen"}));
  }
}