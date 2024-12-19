using System;
using System.Linq;
public class CyclicalPermutation
{
  public static string Pattern(int n)
  {
    if(n < 1){
        return "";
    }
    return string.Join("\n",Enumerable.Range(0,n).Select(x=>string.Concat(Enumerable.Range(x+1, n-x))+string.Concat(Enumerable.Range(1, x))));
  }

  public static void Main()
  {
    Console.WriteLine(Pattern(4));
  }
}