using System;
using System.Collections.Generic;

public static class Kata
{
  public static string CannonsReady(Dictionary<string, string> gunners)
  {
    // throw new NotImplementedException();
    return gunners.ContainsValue("nay") ?  "Shiver me timbers!" : "Fire!";
  }

  public static void Main(){
    Dictionary<string, string> gunners1 = new Dictionary<string, string>
      {
        {"Mike", "aye"},
        {"Joe", "aye"},
        {"Johnson", "aye"},
        {"Peter", "aye"}
      };
    Dictionary<string, string> gunners2 = new Dictionary<string, string>
      {
        {"Mike", "aye"},
        {"Joe", "nay"},
        {"Johnson", "aye"},
        {"Peter", "aye"}
      };
    Console.WriteLine(CannonsReady(gunners1));
    Console.WriteLine(CannonsReady(gunners2));
  }
}