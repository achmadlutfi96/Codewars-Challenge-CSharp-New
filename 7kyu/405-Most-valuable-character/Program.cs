using System;
using System.Linq;
using System.Collections.Generic;

public class MostValuable
{
    public static char solve(string s){  
        //..
        var firstIndex = new Dictionary<char, int>(); 
        var lastIndex = new Dictionary<char, int>(); 
        for (int i = 0; i < s.Length; i++) 
        { 
          if (!firstIndex.ContainsKey(s[i])) 
          { 
            firstIndex[s[i]] = i; 
          } 
          lastIndex[s[i]] = i; 
        } 
        char maxVal = '\0'; 
        int maxDiff = -1; 
        foreach (var kvp in firstIndex) 
        { 
          char c = kvp.Key; 
          int diff = lastIndex[c] - kvp.Value; 
          if (diff > maxDiff || (diff == maxDiff && c < maxVal)) 
          { 
            maxDiff = diff; 
            maxVal = c; 
          } 
        } return maxVal;

        // Alternative
        // return s.Distinct().OrderByDescending(x => s.LastIndexOf(x) - s.IndexOf(x)).ThenBy(x=>x).First();
    }

    public static void Main()
    {
        Console.WriteLine(solve("aabccc"));
    }
}