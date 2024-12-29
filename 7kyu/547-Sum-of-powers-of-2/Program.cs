using System;
using System.Linq;

public class Kata {
  public static int[] Powers(int n) {
    // your code here
    return Convert.ToString(n, 2).Reverse().Select((v,i)=>v == '1' ? (int)Math.Pow(2,i) : 0).Where(x=>x>0).ToArray();

    // Alternative
    // return Enumerable.Range(0,31).Select(x => 1 << x).Where(b => (b & n) == b).ToArray();
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(",", Powers(6)));
  }
}