using System;
using System.Linq;
public class Kata
{
  /// <summary>
  /// Returns a Boolean representing if a number with its digits concatenated an arbitrary number of times and summed is the same as the original number.</summary>
  /// <param name="number">int to be tested.</param>
  /// <param name="n">int which represents the number of times to concatenate each digit</param>
  public static bool CheckConcatenatedSum(int number, int n)
  {
    // return number == Math.Abs(number).ToString().Select(x=>int.IsNegative(number) ? "-"+string.Concat(Enumerable.Repeat($"{x}",n)) : string.Concat(Enumerable.Repeat($"{x}",n))).Sum(long.Parse);

    return Math.Abs(number) == Math.Abs(number).ToString().Select(x=>string.Concat(Enumerable.Repeat($"{x}",n))).Sum(long.Parse);

    // Alternative 
    // return $"{Math.Abs(number)}".Sum(c => Math.Sign(number) * long.Parse(new string(c, n))) == number;
  }

  public static void Main()
  {
    Console.WriteLine(CheckConcatenatedSum(2997,3));
    Console.WriteLine(CheckConcatenatedSum(-2997,3));
  }
}