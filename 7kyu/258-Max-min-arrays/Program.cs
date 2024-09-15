using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> Solve(List<int> arr)
  {
    // throw new NotImplementedException();
        arr.Sort();
        List<int> results = new();
        int temp;
        for(int i = 0; i < arr.Count(); i++){
          temp = i % 2 == 0 ? arr[arr.Count() - i/2 - 1] : arr[i/2];
          results.Add(temp);
        }
        return results;

        // Alternative
        // return Enumerable.Range(0, arr.Count).Select(i => i % 2 == 0
        // ? arr.OrderByDescending(x => x).Skip(i / 2).First()
        // : arr.OrderBy(x => x).Skip(i / 2).First()).ToList();
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", Solve(new List<int> {15,11,10,7,12})));
    Console.WriteLine(string.Join(",", Solve(new List<int> {})));
  }
}

// Console.WriteLine("Hello");