using System;
using System.Linq;
using System.Collections.Generic;
public class Sumpowdig {
    
    public static long[] EqSumPowDig(long hmax, int exp) 
    {
        // your code
        List<long> results = new List<long>();
        for (long i = 2; i <= hmax; i++ ){
            if(i.ToString().Select(x=>Math.Pow(char.GetNumericValue(x),exp)).Sum() == i){
                results.Add(i);
            }
        }
        return results.ToArray();

        // Alternative
        // return Enumerable.Range(2, (int) hmax - 1)
        // .Where(i => (int) $"{i}".Sum(c => Math.Pow(long.Parse($"{c}"), exp)) == i)
        // .Select(i => (long) i)
        // .ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ",EqSumPowDig(400, 3)));
    }
}