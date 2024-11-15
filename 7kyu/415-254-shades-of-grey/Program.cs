using System;
using System.Linq;

public static class Kata {
  public static string[] ShadesOfGrey(int n) {
    // returns n shades of grey in an array
    if(n < 1){
        return new string[0];
    }
    if(n > 254){
        n = 254;
    }
    return Enumerable.Range(1, n).Select(x=>$"#{string.Concat(Enumerable.Repeat(Convert.ToString(x, 16).PadLeft(2, '0'),3))}").ToArray();

    // Alternative 1
    // if (n < 0)
    //   n = 0;
  
    // return Enumerable
    //   .Range(1, Math.Min(n, 254))
    //   .Select(x => string.Format("#{0:x2}{0:x2}{0:x2}", x))
    //   .ToArray();

    // Alternative 2
    // return Enumerable.Range(1, 254).Take(n).Select(i => $"#{i:x2}{i:x2}{i:x2}").ToArray();
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(", ",ShadesOfGrey(10)));
  }
}