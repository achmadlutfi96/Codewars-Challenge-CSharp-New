using System;
using System.Linq;
using System.Numerics;
using System.Collections;

public class DeltaBits
{
    public static int ConvertBits(int a, int b)
    {
        string bitA = Convert.ToString(a, 2);
        string bitB = Convert.ToString(b, 2);
        if(bitA.Length > bitB.Length){
            bitB = bitB.PadLeft(bitA.Length, '0');
        }else{
            bitA = bitA.PadLeft(bitB.Length, '0');
        }
        return bitA.Select((v,i)=>Math.Abs(char.GetNumericValue(v)-char.GetNumericValue(bitB[i]))).Count(v=>v==1);

        // Alternative 1
        // return new BitArray(new[] {a ^ b}).Cast<bool>().Count(x => x);

        // Alternative 2
        // return BitOperations.PopCount((uint) (a ^ b));
    }

    public static void Main()
    {
        Console.WriteLine(ConvertBits(31, 14));
    }
}