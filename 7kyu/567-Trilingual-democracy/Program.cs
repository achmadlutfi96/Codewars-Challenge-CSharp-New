// input is a string of three chars from the set
// 'D', 'F', 'I', 'K'; output is a single char from this set
using System;
using System.Linq;
using System.Collections.Generic;
public static class Kata
{
  public static char TrilingualDemocracy(string group)
  {
    // implement the rules...
    // Rule 1: If all three languages are the same 
    if (group[0] == group[1] && group[1] == group[2]) 
    { 
      return group[0]; 
    }
    
    // Rule 2: If two languages are the same and the third is different 
    Dictionary<char, int> languageCount = group.GroupBy(l => l) .ToDictionary(g => g.Key, g => g.Count()); 
    if (languageCount.Values.Any(count => count == 2)) 
    { 
      return languageCount.First(pair => pair.Value == 1).Key; 
    }
    
    // Rule 3: If all three languages are different 
    char[] allLanguages = { 'D', 'F', 'I', 'K' }; 
    foreach (char lang in allLanguages) 
    { 
      if (!group.Contains(lang)) 
      { 
        return lang; 
      } 
    }
    
    return group[0];
  }
}
