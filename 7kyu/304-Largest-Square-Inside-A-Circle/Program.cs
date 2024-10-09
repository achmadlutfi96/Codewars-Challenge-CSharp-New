namespace Kata
{
    using System;
    public class Circle
    {
        public static double AreaLargestSquare(int r)
        {
            return r * (r * 2);

            //   Alternative
            // return 2*r*r;
        }

        public static void Main()
        {
            Console.WriteLine(AreaLargestSquare(15));
        }
    }
}