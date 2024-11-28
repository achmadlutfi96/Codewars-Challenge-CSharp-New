namespace myjinxin
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int MagicalWell(int a, int b, int n)
        {
            //coding and coding..

            return Enumerable.Range(0, n).Select(x => (a + x) * (b + x)).Sum();

            //    Alternative
            // return n == 0 ? 0 : a * b + MagicalWell(a + 1, b + 1, n - 1);
        }

        public static void Main()
        {
            Console.WriteLine(MagicalWell(6, 5, 3));
        }
    }
}