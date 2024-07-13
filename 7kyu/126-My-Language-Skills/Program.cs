using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static IEnumerable<string> MyLanguages(Dictionary<string, int> results)
  {
    // throw new NotImplementedException();

    List<string> languages = new List<string>();
    foreach (var item in results.OrderByDescending(x=>x.Value).Where(x=>x.Value >= 60))
    {
        languages.Add(item.Key);   
    }
    return languages;

    // Alternative
    // return results.Where(x => x.Value >= 60).OrderByDescending(x => x.Value).Select(x => x.Key);
  }

  public static void Main(){
    foreach (var item in MyLanguages(new Dictionary<string, int> {{"Java", 10}, {"Ruby", 80}, {"Python", 65}}))
    {
        Console.WriteLine(item);
    }
  }
}