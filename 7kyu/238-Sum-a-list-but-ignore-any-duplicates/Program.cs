using System;
using System.Linq;

public class Kata
{
  public static int SumNoDuplicates(int[] arr)
  {
    //write your solution here
    return arr.Distinct().Where(x=>arr.Where(y=>x==y).Count() == 1).Sum();

    // Alternative
    // return arr.Sum(x => arr.Count(i => i == x) == 1 ? x : 0);
  }

  public static void Main(){
    Console.WriteLine(SumNoDuplicates(new int[]{1,1,2,3}));
  }
}