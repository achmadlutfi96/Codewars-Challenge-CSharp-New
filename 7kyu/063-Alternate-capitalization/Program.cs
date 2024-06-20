using System;
using System.Linq;

public static class Kata
{
  public static string[] Capitalize(string s)
  {
    
    return new string[]{
        string.Concat(s.Select((v, i)=> (i+1)%2 == 1 ? v.ToString().ToUpper() : v.ToString().ToLower()).ToArray()),
        string.Concat(s.Select((v, i)=> (i+1)%2 == 0 ? v.ToString().ToUpper() : v.ToString().ToLower()).ToArray()),
        };

    // Alternative
    // return Enumerable.Range(0, 2).Select(n => string.Concat(s.Select((x, i) => i % 2 == n ? char.ToUpper(x) : x))).ToArray();
  }

  public static void Main(){
    foreach (var item in Capitalize("abcdef"))
    {
        Console.WriteLine(item.ToString());
    }
  }
}