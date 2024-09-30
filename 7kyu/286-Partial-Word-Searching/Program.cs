using System;
using System.Linq;

public class Kata
{
  public static string[] WordSearch(string query, string[] seq)
  {
    return seq.Where(x=>x.ToLower().Contains(query.ToLower())).DefaultIfEmpty("Empty").ToArray();
  }

  public static void Main(){
    Console.WriteLine(String.Join(",", WordSearch("ab", new string[] {"za", "ab", "abc", "zab", "zbc"})));
  }
}