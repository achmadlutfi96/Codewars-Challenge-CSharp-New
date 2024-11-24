using System;
using System.Linq;
public class HorizontalImageOfPart2
{
  public static string Pattern(int n)
  {
    return n > 0 ? string.Join("\n", Enumerable.Range(1,n).Select(x=> string.Concat(Enumerable.Range(x,n-x+1).Reverse())).Reverse()) : "";

    // Alternative
    // string s = "";
    // return n<1?"": string.Join("\n",Enumerable.Range(1,n).Select(t=>s+=n--));
  }

  public static void Main()
  {
    Console.WriteLine(Pattern(6));
  }
}