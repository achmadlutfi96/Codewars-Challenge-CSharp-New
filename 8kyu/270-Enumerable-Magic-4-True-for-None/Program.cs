using System;
using System.Linq;

public class Kata
{
  public static bool None(int[] arr, Func<int, bool> fun)
  {
    foreach (var item in arr)
    {
        if(fun(item) == true){
            return false;
        }
    }
    return true;

    // Alternative
    // return !arr.Any(fun);
  }

  public static void Main(){
    Console.WriteLine(None(new int[] { 1,2,3,4,5 }, v => v > 5));
    Console.WriteLine(None(new int[] { 1,2,3,4,5 }, v => v > 4));
  }
}