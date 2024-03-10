using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    // Your code here
    // int res = 0;
    // foreach (var n in arr)
    // {
    //     res += n > 0 ? n : 0;
    // }
    // return res;
    
    return arr.Where(x => x > 0).Sum();
  }
}

class SumOfPositive
{
    public static void Main(){
        Console.WriteLine(Kata.PositiveSum(new int[]{1, 2, 3, 4, 5}));
        Console.WriteLine(Kata.PositiveSum(new int[]{1, -2, 3, 4, 5}));
    }
}