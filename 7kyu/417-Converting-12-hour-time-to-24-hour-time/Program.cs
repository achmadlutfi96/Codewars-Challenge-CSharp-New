using System;
namespace Kata
{
    public class TimeConvert
    {
        public static string Convert12hTo24h(int hours, int minutes, string period)
        {
            if (period == "am" && hours == 12)
            {
                return $"00{minutes:D2}";
            }
            if (period == "pm" && hours == 12)
            {
                return $"12{minutes:D2}";
            }
            return Convert.ToString(period == "pm" ? hours + 12 : hours).PadLeft(2, '0') + $"{minutes}".PadLeft(2, '0');

            // Alternative 1
            // return TimeOnly.Parse($"{hours}:{minutes}{period}").ToString("HHmm");

            // Alternative 2
            // return $"{hours % 12 + (period == "pm" ? 12 : 0) :D2}{minutes:D2}";

        }

        public static void Main()
        {
            Console.WriteLine(Convert12hTo24h(2, 15, "pm"));
        }
    }
}