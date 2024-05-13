using System;
using System.Linq;
public class Kata
{
  public static bool IsOpposite(string s1, string s2)
  {
    //coding here...
    return string.IsNullOrEmpty(s1) ? false : string.Concat(s1.Select(s=>char.IsUpper(s)? char.ToLower(s): char.ToUpper(s)).ToArray()).Equals(s2);
  }

  public static void Main(){
    Console.WriteLine(IsOpposite("aB","Ab"));
  }
}