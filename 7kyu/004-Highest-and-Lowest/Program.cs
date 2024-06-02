using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    // Code here or
    int[] num = numbers.Split(" ").Select(n => int.Parse(n)).ToArray();
    return string.Join(" ",num.Max(), num.Min());

    // Alternative
    // var numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));
    // return string.Format("{0} {1}", numbersList.Max(), numbersList.Min());
  }

  public static void Main(){
    Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
  }
}