using System;
using System.Linq;

public class SequenceSum
{
    public static string ShowSequence(int n)
    {
        if (n == 0)
        {
            return "0=0";
        }
        else if (n < 0)
        {
            return $"{n}<0";
        }
        else
        {
            int[] numbers = Enumerable.Range(0, n + 1).ToArray();
            return n == 0 ? "0=0" : $"{string.Join('+', numbers)} = {numbers.Sum()}";
        }

        // Alternative
        // if(n < 0) return $"{n}<0";
        // if(n == 0) return "0=0";

        // IEnumerable<int> sequence = Enumerable.Range(0, n+1);

        // return $"{String.Join("+", sequence)} = {sequence.Sum()}";
    }

    public static void Main()
    {
        Console.WriteLine(ShowSequence(6));
    }
}