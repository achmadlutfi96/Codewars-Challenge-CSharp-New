using System;
using System.Linq;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    // Bust a move right here
    // return Convert.ToInt32(string.Concat(num.ToString().OrderDescending(x=>x).ToArray()));

    char[] n = num.ToString().ToArray();
    Array.Sort(n);
    Array.Reverse(n);
    return int.Parse(string.Concat(n));
  }

  public static void Main(){
    Console.WriteLine(DescendingOrder(145263));
  }
}
