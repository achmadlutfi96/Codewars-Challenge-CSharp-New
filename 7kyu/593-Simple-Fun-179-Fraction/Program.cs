namespace myjinxin
{
    using System;

    public class Kata
    {
        public int Fraction(int a, int b)
        {
            //coding and coding..

            int gcd = GCD(a, b);
            int reducedNumerator = a / gcd;
            int reducedDenominator = b / gcd;
            return reducedNumerator + reducedDenominator;

            // Alternative
            // int gcd = (int)BigInteger.GreatestCommonDivisor(new BigInteger(a), new BigInteger(b));
            //   return a / gcd + b / gcd;
        }
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}