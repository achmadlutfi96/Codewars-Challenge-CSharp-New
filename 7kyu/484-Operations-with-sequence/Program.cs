using System;
using System.Linq;

public static class Kata
{
    public static int Calc(int[] array)
    {
      return (int) array.Select(v=>v > 0 ? Math.Pow(v,2) : v).Select((v,i)=>(i+1)%3 == 0 ? v*3 : v).Select((v,i)=>(i+1)%5 == 0 ? v*-1 : v).Sum();

    //   Alternative 
    // return array.Select((x,i) => 
    //     (x > 0 ? x * x : x)
    //     * (i % 3 == 2 ? 3 : 1)
    //     * (i % 5 == 4 ? -1 : 1))
    //   .Sum();
    }

    public static void Main()
    {
        Console.WriteLine(Calc(new[]{ 0, 2, 1, -6, -3, 3 }));
    }
}