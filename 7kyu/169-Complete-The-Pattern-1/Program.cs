using System;
using System.Linq;

public class Kata
{
  public static string Pattern(int n)
  {
    // Happy Coding ^_^
    if(n<1) return "";
    return String.Join("\n", Enumerable.Range(1, n).Select((v,i)=>String.Concat(Enumerable.Repeat(v.ToString(), i+1))));

    // Alternative 
    // return string.Join("\n",
    //   Enumerable
    //     .Range(1, Math.Max(0, n))
    //     .Select(i => i.ToString().Repeat(i)));
  }

  public static void Main(){
    Console.WriteLine(Pattern(11));
  }
}