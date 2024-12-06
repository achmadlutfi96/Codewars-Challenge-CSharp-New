using System;
using System.Linq;
public static class Kata
{
    public static bool Interlockable(ulong a, ulong b)
    {
        //  <----  hajime!
        string bin1 = Convert.ToString((long)a, 2);
        string bin2 = Convert.ToString((long)b, 2);
        if(bin1.Length > bin2.Length){
            bin2 = bin2.PadLeft(bin1.Length,'0');
        }else{
            bin1 = bin1.PadLeft(bin2.Length,'0');
        }
        return bin1.Select((v,i)=>v == '1' && bin2[i] == '1' ).All(x => x == false);

        // Alternative
        // return (a & b) == 0;
        // https://en.wikipedia.org/wiki/Bitwise_operation
    }

    public static void Main()
    {
        Console.WriteLine(Interlockable(9UL, 4UL));
        Console.WriteLine(Interlockable(5UL, 6UL));
    }
}