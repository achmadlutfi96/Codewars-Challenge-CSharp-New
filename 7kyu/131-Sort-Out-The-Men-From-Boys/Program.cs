using System;

public class Kata {
  public static int[] MenFromBoys(int[] a) {
    // your code here
    return a.Where(x=>x%2==0)
            .OrderBy(y=>y)
            .Concat(a.Where(x=>x%2!=0)
                        .OrderByDescending(y=>y))
            .Distinct()
            .ToArray();
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", MenFromBoys(new int[] { 2, 43, 43, 95, 90, 37 })));
    foreach (var item in MenFromBoys(new int[] { -94, -99, -100, -99, -96, -99}))
    {
        Console.WriteLine(item);
    }
  }
}