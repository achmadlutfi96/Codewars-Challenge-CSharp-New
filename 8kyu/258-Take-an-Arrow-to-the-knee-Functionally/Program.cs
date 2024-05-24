using System;
using System.Linq;

// Preloaded method Tools.FromCharCode(int i) available!

public class Kata
{
  public static string ArrowFunc(int[] arr)
  {
    return string.Join("", arr.Select( s => Convert.ToChar(s) ).ToArray());

    // Alternative
    // return string.Join("", arr.Select( num => Tools.FromCharCode(num)   ).ToArray());
    // return string.Concat(arr.Select(n => (char)n));
  }

  public static void Main(){
    Console.WriteLine(ArrowFunc(new int[]{84,101,115,116}));
  }
}