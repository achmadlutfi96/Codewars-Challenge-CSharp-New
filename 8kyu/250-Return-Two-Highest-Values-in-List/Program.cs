using System;
using System.Linq;

public static class Kata
{
  public static int[] TwoHighest(int[] arr)
  {
    
    if (arr.Length == 0){
        return new int[]{};
    }
    Array.Sort(arr);
    arr = arr.Distinct().ToArray();
    if(arr.Length == 1){
        return new int[]{arr[0]};
    }
    int max1 = arr[arr.Length-1];
    int max2 = arr[arr.Length-2];
    return max1 == max2 ? new int[]{max1} : new int[]{max1, max2};

    // Alternative
    // return arr.Distinct().OrderByDescending(x => x).Take(2).ToArray();
  }

  public static void Main(){
    foreach (var item in TwoHighest(new[] { 15, 20, 20, 17 }))
    {
        Console.WriteLine(item);
    }
  }
}