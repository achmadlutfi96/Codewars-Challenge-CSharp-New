using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        //your code here
        return data.Select(d => d[0] >= 55 && d[1]> 7 ? "Senior" : "Open");
    }

    public static void Main(){
        foreach (var item in OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }))
        {
            Console.WriteLine(item);
        }
    }
}