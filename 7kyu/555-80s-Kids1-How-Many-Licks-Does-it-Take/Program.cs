using System;
using System.Collections.Generic;

public class Kata
{
    public string TotalLicks(Dictionary<string, int> env)
    {
        int normalLicks = 252;
        int totalLicks = normalLicks + env.Sum(x=>x.Value);
        return env.Where(x=>x.Value > 0).Count() > 0 ? 
          $"It took {totalLicks} licks to get to the tootsie roll center of a tootsie pop. The toughest challenge was {env.OrderByDescending(x=>x.Value).First().Key}." : 
          $"It took {totalLicks} licks to get to the tootsie roll center of a tootsie pop.";
    }
}