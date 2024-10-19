using System;

public static class Kata
{
    public static int HowManyYears(string date1, string date2)
    {
        DateOnly d1 = DateOnly.Parse(date1);
        DateOnly d2 = DateOnly.Parse(date2);
        return (int) Math.Abs(d1.Year - d2.Year);

        // Alternative
        // return Math.Abs(DateTime.Parse(date1).Year - DateTime.Parse(date2).Year);
    }

    public static void Main()
    {
        Console.WriteLine(HowManyYears("1997/10/10", "2015/10/10"));
    }
}