using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static bool IsZeroBalanced(List<int> xs)
  {
    // throw new NotImplementedException();
    if (xs.Count == 0) return false; 
    if (xs.Sum() != 0) return false; 
    List<int> positiveElements = new List<int>(); 
    List<int> negativeElements = new List<int>(); 
    foreach (int num in xs) { 
      if (num > 0) positiveElements.Add(num); 
      else if (num < 0) negativeElements.Add(num); 
    } 

    positiveElements.Sort();
    negativeElements.Sort();
    negativeElements.Reverse();
    
    if(positiveElements.Count != negativeElements.Count)
    {
        return false;
    }
    for (int i = 0; i < positiveElements.Count; i++)
    {
        if (-positiveElements[i] != negativeElements[i])
        {
            return false;
        }
    }
    
    return true;

    // Alternative
    // return xs.Any() && xs.Sum() == 0 && xs.All(i => xs.Contains(-i));
  }
}