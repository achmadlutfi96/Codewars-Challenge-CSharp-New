using System;
using System.Linq;

public static class Kata
{
    public static int[] LastDigit(long n, int d)
    {
        return n.ToString().TakeLast(d).Select(x=>(int)char.GetNumericValue(x)).ToArray();

        // Alternative
        // return $"{n}".TakeLast(d).Select(c => c - '0').ToArray();
    }

    public static void Main(){
        Console.WriteLine(string.Join(",",LastDigit(34625647867585, 10)));
    }
}