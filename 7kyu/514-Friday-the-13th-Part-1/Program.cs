using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static string[] KillCount(Dictionary<string, int> counselors, int jason)
  {
    // insert your code here
    return counselors.Where(x=>x.Value < jason).Select(x=>x.Key).ToArray();
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(", ",KillCount(new Dictionary<string, int> 
      {
        {"Mike", 7},
        {"Alysa", 3}
      }, 7)));
  }
}