using System;
using System.Linq;

public class Kata
{
  public static bool All(int[] arr, Func<int, bool> fun)
  {
    return arr.Select(fun).All(v=>v == true);

    // Alternative
    // return arr.All(fun);
  }

  public static void Main(){
    Console.WriteLine(All(new int[] { 1,2,3,4,5 }, v => v < 9));
  }
}