using System;
using System.Linq;

public class Kata
{
    public static int[] SortByValueAndIndex(int[] array)
    {
        return array.Select((v,i)=>new int[]{v , v*(i+1)}).OrderBy(x=>x[1]).Select(x=>x[0]).ToArray();

        // Alternative
        // return array.OrderBy(n => n * i++).ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(",",SortByValueAndIndex(new int[] { 23, 2, 3, 4, 5 })));
    }
}