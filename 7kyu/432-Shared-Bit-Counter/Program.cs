using System;
using System.Linq;
using System.Numerics;
namespace BinaryOperators
{
    public class BitCounting
    {
        public static bool SharedBits(int a, int b)
        {
            //insert code here
            char[] aBin = Convert.ToString(a, 2).Reverse().ToArray();
            char[] bBin = Convert.ToString(b, 2).Reverse().ToArray();
            return aBin.Length >= bBin.Length ? aBin.Where((v, i) => v == '1' && bBin[i] == '1').Count() >= 2 : bBin.Where((v, i) => v == '1' && aBin[i] == '1').Count() >= 2;

            // Alternative 1
            // return Convert.ToString(a & b, 2).Count(x => x == '1') >= 2;

            // Alternative 2
            // return BitOperations.PopCount((uint) a & (uint) b) > 1;

            // Alternative 3
            // return ((a&b) & ((a&b)-1)) != 0;


        }

        public static void Main()
        {
            Console.WriteLine(SharedBits(43, 77));
        }
    }
}