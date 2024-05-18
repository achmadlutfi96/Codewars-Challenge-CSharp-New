using System;

public static class Kata
{
  public static bool PeriodIsLate(DateTime last, DateTime today, int cycleLength)
  {
    return today.Subtract(last).Days > cycleLength ? true : false ;

    // Alternative 
    // return (today - last).TotalDays > cycleLength;
  }

  public static void Main(){
    Console.WriteLine(PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 07, 16), 35));
    Console.WriteLine(PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 07, 16), 28));
  }
}