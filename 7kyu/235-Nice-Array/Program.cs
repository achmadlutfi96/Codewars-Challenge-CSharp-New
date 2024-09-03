using System;
using System.Linq;

public class Kata
{
  public static bool IsNice(int[] arr)
  {
    // throw new NotImplementedException();
    if(arr.Length == 0){
        return false;
    }
    return arr.Where(x=>arr.Contains(x-1) || arr.Contains(x+1)).Count() == arr.Length;

    // Alternative
    // return arr.Any() && arr.All(x => arr.Contains(x - 1) || arr.Contains(x + 1));
  }

  public static void Main(){
    Console.WriteLine(IsNice(new int[] {2,10,9,3}));
    Console.WriteLine(IsNice(new int[] {3,4,5,7}));
  }
}