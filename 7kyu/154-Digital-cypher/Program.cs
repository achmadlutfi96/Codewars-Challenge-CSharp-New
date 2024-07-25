using System.Linq;
using System;

public class Kata
{
    public static int[] Encode(string str, int n)
    {
        int[] strArr= str.Select(x=>x-96).ToArray();
        int[] nArr= n.ToString().Select(x=>(int)char.GetNumericValue(x)).ToArray();
        return strArr.Select((x,i)=>x+nArr[i%nArr.Length]).ToArray();

        // Alternative
        // return str.Select((c, i) => c - 96 + ($"{n}"[i % $"{n}".Length] - '0')).ToArray();
    }

    public static void Main(){
        Console.WriteLine(string.Join(",", Encode("masterpiece", 1939)));
    }
}
