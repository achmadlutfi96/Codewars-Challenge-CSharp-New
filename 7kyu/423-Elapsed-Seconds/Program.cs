using System;

public class Kata
{
  public static int ElapsedSeconds(DateTime startDate, DateTime endDate)
  {
    return (int) endDate.Subtract(startDate).TotalSeconds;

    // Alternative
    // return (int)(endDate - startDate).TotalSeconds;
  }

  public static void Main()
  {
    Console.WriteLine(ElapsedSeconds(new DateTime(2013, 1, 1, 0, 0, 1), new DateTime(2013, 1, 1, 0, 0, 2)));
  }
}