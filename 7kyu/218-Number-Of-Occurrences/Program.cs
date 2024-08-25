using System;
using System.Linq;

public class OccurrencesKata
{
    public static int NumberOfOccurrences(int x, int[] xs)
    {
        return xs.Where(y=>y==x).Count();

        // Alternative
        // return xs.Count(Item => Item == x);
    }

    public static void Main(){
        Console.WriteLine(NumberOfOccurrences(4, new int[] { 4, 0, 4 }));
    }
}