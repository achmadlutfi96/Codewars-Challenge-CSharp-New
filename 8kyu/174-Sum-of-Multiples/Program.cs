using System.Linq;
using System;
public class Kata
{
  public static int SumMul(int n, int m)
  {
    // your idea here
    if(n>=m || n < 1) throw new ArgumentException();
    return Enumerable.Range(0, m-n).Select(x=>n+x).Where(i=>i%n==0).Sum();

    // ALternative
    // return Enumerable.Range(n, m - n).Where(x => x % n == 0).Sum();
  }

  public static void Main(){
    Console.WriteLine(SumMul(5, 20));
    Console.WriteLine(SumMul(2, 9));
   Console.WriteLine(SumMul(9, 2));
  }
}