namespace myjinxin
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int ShapeArea(int n)
        {
            //coding and coding..

            return Enumerable.Range(0, n).Aggregate(1, (v, n) => v + (n * 4));

            //   Alternative 1
            // return((n*n)+((n-1)*(n-1)));

            // Alternative 2
            // return (int)Math.Pow(n, 2) + (int)Math.Pow(n - 1, 2);
        }

        public static void Main()
        {
            Console.WriteLine(ShapeArea(3));
            Console.WriteLine(ShapeArea(1));
            Console.WriteLine(ShapeArea(2));
            Console.WriteLine(ShapeArea(4));
            Console.WriteLine(ShapeArea(5));
        }
    }
}