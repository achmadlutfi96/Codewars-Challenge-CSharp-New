namespace myjinxin
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int KillKthBit(int n, int k)
        {
            //coding and coding..

            return Convert.ToInt32(string.Concat(Convert.ToString(n, 2).Reverse().Select((v, i) => i + 1 == k ? '0' : v).Reverse()), 2);

            // Alternative 1
            // return n & ~(1<<k-1);

            // Alternative 2
            // return n&~(1<<--k);
        }

        public static void Main()
        {
            Console.WriteLine(KillKthBit(37, 3) == 33);
            Console.WriteLine(KillKthBit(37, 4) == 37);
        }
    }
}