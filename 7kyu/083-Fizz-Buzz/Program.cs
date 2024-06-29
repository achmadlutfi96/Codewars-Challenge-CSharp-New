using System;
using System.Collections.Generic;
using System.Linq;

public class FizzBuzz
{
    public static string[] GetFizzBuzzArray(int n)
    {
        // return Array.Empty<string>();
        return Enumerable.Range(1, n).Select(s => s%3==0 && s%5==0 ? "FizzBuzz" : s%3==0 ? "Fizz" : s%5==0 ? "Buzz" : s.ToString()).ToArray();
    }

    public static void Main()
    {
        foreach (var item in GetFizzBuzzArray(15))
        {
            Console.WriteLine(item);
        }
    }
}