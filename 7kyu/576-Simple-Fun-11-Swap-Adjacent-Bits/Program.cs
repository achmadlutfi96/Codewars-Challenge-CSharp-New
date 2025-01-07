namespace myjinxin
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int SwapAdjacentBits(int n)
        {
            //coding and coding..
            string binary = Convert.ToString(n, 2).PadLeft(32, '0');
            return Convert.ToInt32(string.Concat(Enumerable.Range(0, 16).Select(x => binary.Substring(x * 2, 2)).Select(x => $"{x[1]}{x[0]}")), 2);

            //   Alternative
            // return unchecked((n & (int)0x55555555) << 1 | (n & (int)0xaaaaaaaa) >> 1);
        }

        public static void Main()
        {
            Console.WriteLine(SwapAdjacentBits(74));
        }
    }
}