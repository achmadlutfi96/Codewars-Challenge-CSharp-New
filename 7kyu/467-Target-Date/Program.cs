using System;
using System.Globalization;
public class DateDays 
{
    
    public static String DateNbDays(double a0, double a, double p) 
	{
		// your code
        int day = 0;
        while(a0 <= a){
            a0 += a0 *(p/36000);
            day++;
        }
        return new DateOnly(2016, 1,1).AddDays(day).ToString("yyyy-MM-dd");

        // Alternative
        // return $"{new DateTime(2016, 1, 2).AddDays((int) Math.Log(a / a0, 1 + p / 36000)):yyyy-MM-dd}";
    }

    public static void Main()
    {
        Console.WriteLine(DateNbDays(100, 101, 0.98d));
        Console.WriteLine(DateNbDays(100, 150, 2));
    }
}