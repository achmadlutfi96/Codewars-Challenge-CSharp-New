using System;
using System.Linq;
public class EvenLadder
{
  public static string Pattern(int n)
  {
    return n > 0 ? string.Join("\n",Enumerable.Range(1,n).Where(x=>x%2==0).Select(x=>string.Concat(Enumerable.Repeat($"{x}",x)))) : "";
  }

  public static void Main()
  {
    Console.WriteLine(Pattern(5));
  }
}