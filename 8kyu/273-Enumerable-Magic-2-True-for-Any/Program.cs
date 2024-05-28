using System;

public class Kata
{
  public static bool Any(int[] arr, Func<int,bool> fun)
  {
    foreach (var item in arr)
    {
        if(fun(item) == true){
            return true;
        }        
    }
    return false;

    // Alternative
    // return arr.Any(fun);
  }
  public static void Main(){
    Console.WriteLine(Any(new int[] { 1,2,3,4 }, v => v > 3));
    Console.WriteLine(Any(new int[] { 1,2,3,4 }, v => v > 4));
  }
}