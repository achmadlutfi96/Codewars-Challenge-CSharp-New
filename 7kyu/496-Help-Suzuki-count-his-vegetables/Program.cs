using System.Collections.Generic;
using System;
using System.Linq;
public class Suzuki
{
  public static List<Tuple<int,string>> CountVegetables(string s)
  {
    string[] veggies = SuzukiHelper.Veggies; // Contains all vegetables as strings.
    string[] sv = s.Split(" "); 
    List<Tuple<int,string>> res = new();
    foreach(string item in veggies){
        res.Add(new Tuple<int, string>(sv.Count(x=>x==item), item));
    }
    return res.OrderByDescending(x=>x).ToList();

    // Alternative
    // return s.Split(' ')
            .Where(x => SuzukiHelper.Veggies.Contains(x))
            .GroupBy(x => x)
            .Select(x => new Tuple<int, string>(x.Count(), x.Key))
            .OrderByDescending(x => x.Item1)
            .ThenByDescending(x => x.Item2)
            .ToList();
  }
}