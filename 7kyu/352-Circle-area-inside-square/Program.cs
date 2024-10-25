namespace Kata
{
    using System;
    public class Convert
    {
        public static double SquareAreaToCircle(double size)
        {
            return Math.Round(size * Math.PI /4.0,8);
        }

        public static void Main()
        {
            Console.WriteLine(SquareAreaToCircle(9));
            Console.WriteLine(SquareAreaToCircle(20));
        }
    }
}