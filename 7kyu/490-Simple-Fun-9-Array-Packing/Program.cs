namespace myjinxin
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int ArrayPacking(int[] a)
        {
            //coding and coding..
            return Convert.ToInt32(string.Concat(a.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).Reverse()), 2);

            //   Alternative 1
            // return arr.Reverse().Aggregate(0, (a, v) => (a << 8) + v);

            // Alternative 2
            // return a.Select((x, i) => x << i * 8).Sum();
        }

        public static void Main()
        {
            Console.WriteLine(ArrayPacking(new int[] { 24, 85, 0 }));
        }
    }
}