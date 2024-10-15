namespace myjinxin
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int RangeBitCount(int a, int b)
        {
            //coding and coding..
            return Enumerable.Range(a, b - a + 1).Select(x => Convert.ToString(x, 2).Where(y => y == '1').Count()).Sum();

            // Alternative 1
            //   return Enumerable.Range(a,b-a+1).Select(x=>x.ToString("b").Where(y=>y=='1').Count()).Sum();

            // Alternative 2
            // return string.Concat(Enumerable.Range(a, b - a + 1).Select(x => Convert.ToString(x, 2))).Count(x=> x == '1');
        }

        public static void Main()
        {
            Console.WriteLine(RangeBitCount(2, 7));
            Console.WriteLine(RangeBitCount(0, 1));
            Console.WriteLine(RangeBitCount(4, 4));
        }
    }
}