using System;
using System.Numerics;

public class BinaryScore
{
    public static BigInteger Score(BigInteger n)
    {
        // Good Luck!
        BigInteger score = 0;
        while(n > 0){
            score |= n;
            n >>= 1;
        }
        return score;

        // Alternative 1
        // return BigInteger.Pow(2, (int) Math.Ceiling(BigInteger.Log(n + 1, 2))) - 1;

        
    }

    public static void Main()
    {
        Console.WriteLine(Score(BigInteger.Parse("49")));
    }
}