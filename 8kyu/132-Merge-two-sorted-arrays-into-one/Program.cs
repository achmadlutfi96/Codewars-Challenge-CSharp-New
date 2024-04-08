using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int[] MergeArrays(int[] arr1, int[] arr2)
  {
    int[] arr3 = arr1.Union(arr2).ToArray();
    Array.Sort(arr3);
    return arr3;
    // Alternative
    // return arr1.Union(arr2).OrderBy(i => i).ToArray();
    // return arr1.Concat(arr2).Distinct().OrderBy(x => x).ToArray();
  }
  public static void Main(){
    foreach(var item in MergeArrays(new[] {1, 2, 3, 4}, new[] {5, 6, 7, 8})){
        Console.WriteLine(item);
    }
  }
}