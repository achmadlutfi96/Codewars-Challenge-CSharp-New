using System;
using System.Linq;
public class Flip
{
    public static int FlipBit(int value, int bitIndex)
    {
        //Go
        string bit = Convert.ToString(value, 2);

        if(bitIndex >= bit.Length){
            bit = bit.PadLeft(bitIndex,'0');
            bit = string.Concat(bit.Select((v,i) => i == bit.Length-bitIndex ? (v == '1'? '0' : '1') : v));
        }
        else
        {
            bit = string.Concat(bit.Select((v,i) => i == bit.Length-bitIndex ? (v == '1'? '0' : '1') : v));
        }

        return Convert.ToInt32(bit, 2);

        // Alternative
        // return (1 << bitIndex - 1) ^ value; 
    }

    public static void Main()
    {
        Console.WriteLine(FlipBit(15, 4));
        Console.WriteLine(FlipBit(15, 5));
        Console.WriteLine(FlipBit(3, 8));
    }
}