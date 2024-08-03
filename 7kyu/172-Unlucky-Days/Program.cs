using System;
public class Kata
{
  public static int UnluckyDays(int year)
  {
        int result = 0;
        DateOnly day;

		for (int i = 1; i <= 12; i++) {
			day = new DateOnly(year, i, 13);
			if (day.DayOfWeek == DayOfWeek.Friday) {
				result++;
			}
		}
		return result;

        // Alternative
        // return Enumerable.Range(1, 12).Select(x => new DateTime(year, x, 13)).Count(x => x.DayOfWeek == DayOfWeek.Friday);
  }

  public static void Main(){
    Console.WriteLine(UnluckyDays(2015));
  }
}