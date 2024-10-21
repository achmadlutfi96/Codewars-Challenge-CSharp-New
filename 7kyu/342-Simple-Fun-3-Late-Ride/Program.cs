namespace myjinxin
{
    using System;

    public class Kata
    {
        public static int LateRide(int n)
        {
            //coding and coding..
            return (n / 60).ToString().Sum(x => (int)char.GetNumericValue(x)) + (n % 60).ToString().Sum(x => (int)char.GetNumericValue(x));

            // Alternative
            // return $"{n / 60}{n % 60}".Sum(c => c - '0');

        }

        public static void Main()
        {
            Console.WriteLine(LateRide(808));
        }
    }
}