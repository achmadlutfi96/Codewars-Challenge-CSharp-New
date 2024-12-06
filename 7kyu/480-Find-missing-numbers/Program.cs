using System.Linq;
using System;
public class Kata
{
  public static int[] FindMissingNumbers(int[] arr)
  {
    if(arr.Length == 0 || arr.Length == arr.Max()-arr.Min()+1){
      return new int[0];
    }
    return Enumerable.Range(arr.Min(), arr.Max()-arr.Min()+1).Except(arr).ToArray();

    // Alternative
    // return arr.Any() ? Enumerable.Range(arr[0], arr[^1] - arr[0]).Except(arr).ToArray() : new int[0];
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(", ",FindMissingNumbers(new int[] { -3, -2, 1, 4 })));
    Console.WriteLine(string.Join(", ",FindMissingNumbers(new int[] { -1,0,1,2,3,4 })));
    Console.WriteLine(string.Join(", ",FindMissingNumbers(new int[0])));
  }
}