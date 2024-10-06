using System;

namespace Solution
{
    public static class Program
    {
        public static double Heron(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(s * (s-a) * (s-b) * (s-c)), 2);
        }

        public static void Main()
        {
            Console.WriteLine(Heron(6, 8, 10));
        }
    }
}