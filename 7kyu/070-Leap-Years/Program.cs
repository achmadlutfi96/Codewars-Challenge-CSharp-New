using System;

public static class Kata
{
  public static bool IsLeapYear(int year)
  {
    return DateTime.IsLeapYear(year);
  }

  public static void Main(){
    Console.WriteLine(IsLeapYear(2020));
  }
}