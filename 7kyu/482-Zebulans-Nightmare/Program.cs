using System;
using System.Linq;

public class Kata
{
  public static string ZebulansNightmare(string functionName)
  {
    return string.Concat(functionName.Split("_").Select((v,i)=>i == 0 ? v : char.ToUpper(v[0])+v.Substring(1)));
  }

  public static void Main()
  {
    Console.WriteLine(ZebulansNightmare("mark_as_issue"));
  }
}