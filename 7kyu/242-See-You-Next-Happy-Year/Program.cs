public class Kata
{
    public static short NextHappyYear(short year)
    {
        //Happy Coding!
        short a, b, c, d;
        do
        {
            year = (short)(year + 1);
            a = (short) (year / 1000);
            b = (short)((year - a * 1000) / 100);
            c = (short)((year - a * 1000 - b * 100) / 10);
            d = (short)(year % 10);
        }
        while (!(a != b && b != c && c != d && a != c && a != d && b != d));
        return year;

        // Alternative
        // return (++year).ToString().Distinct().Count() == 4 ? year : nextHappyYear(year);
    }

    public static void Main()
    {
        Console.WriteLine(NextHappyYear(1001));
    }
}