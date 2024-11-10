namespace myjinxin
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int DistinctDigitYear(int year)
        {
            //coding and coding..
            do
            {
                year++;
            } while (!(year.ToString().Distinct().Count() == year.ToString().Length));
            return year;

            //   Alternative
            // return (++year).ToString().Distinct().Count() == 4 ? year : DistinctDigitYear(year);
        }

        public static void Main()
        {
            Console.WriteLine(DistinctDigitYear(1987));
        }
    }
}