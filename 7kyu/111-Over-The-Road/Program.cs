using System;
using System.Linq;
using System.Collections.Generic;
public class CodeWars {
  public static long OverTheRoad(long address, long n) {
    
    // Good luck!
    // List<int> arr1 = Enumerable.Range(1, (int)n*2).Where(x=>x%2==1).ToList();
    // List<int> arr2 = Enumerable.Range(1, (int)n*2).Where(x=>x%2==0).Reverse().ToList();
    // return address%2==1 ? arr2[arr1.IndexOf((int)address)] : arr1[arr2.IndexOf((int)address)];

    return (n*2)-address+1;
  }

  static void Main(){
    Console.WriteLine(OverTheRoad(1, 3));
  }
}