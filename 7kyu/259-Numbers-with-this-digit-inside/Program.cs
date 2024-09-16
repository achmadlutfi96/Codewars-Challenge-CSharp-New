using System.Collections.Generic;
public class Kata
{
  public static long[] NumbersWithDigitInside(long x, long d)
  {
    List<long> numbers = new();
    for (int i = 1; i <= x; i++)
    {
        numbers.Add(i);
    }
    long[] n = numbers.Where(a=>a.ToString().Contains(d.ToString())).ToArray();
    return n.Length == 0 ? new long[]{0,0,0} : new long[] { n.Count(), n.Sum(), n.Aggregate((value, next)=> value * next)};

    // Alternative
    // var n = Enumerable.Range(1, (int) x).Where(i => $"{i}".Contains($"{d}")).ToList();
    // return new[] {n.Count, n.Sum(), n.Any() ? n.Aggregate(1L, (a, b) => a * b) : 0};
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", NumbersWithDigitInside(11, 1)));
    Console.WriteLine(string.Join(",", NumbersWithDigitInside(20, 0)));
    Console.WriteLine(string.Join(",", NumbersWithDigitInside(5, 6)));
  }
}