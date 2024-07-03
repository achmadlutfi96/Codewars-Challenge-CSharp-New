using System;
using System.Linq;

public static class Kata
{
  public static string GenerateShape(int n)
  {
    // throw new NotImplementedException();
    return string.Join('\n', Enumerable.Range(1, n).Select(i=>string.Concat(Enumerable.Repeat("+", n).ToArray())).ToArray());  

    // Alternative 1
    // return string.Join("\n", Enumerable.Repeat(new string('+', n), n));

    // Alternative 2
    // return string.Join("\n", Enumerable.Repeat("".PadLeft(n, '+'), n));
  }

  public static void Main(){
    Console.WriteLine(GenerateShape(3));
  }
}