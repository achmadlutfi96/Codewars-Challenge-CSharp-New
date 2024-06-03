using System;
using System.Linq;
public class Kata
{
  public static string GetMiddle(string s)
  {
  //Code goes here!
    return s.Length % 2 == 0 ? string.Concat(s[(int)MathF.Ceiling(s.Length/2)-1], s[(int)MathF.Floor(s.Length/2)]) : string.Format("{0}",s[(int)MathF.Floor(s.Length/2)]);

    // Alternative
    //  return string.IsNullOrEmpty(s)? s : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
  }

  public static void Main(){
    Console.WriteLine(GetMiddle("test"));
  }
}