using System;
using System.Linq;
using System.Text;

namespace Solution {
  public static class TIY {
   public static string FizzBuzz(string sentence)
    {
        return string.Concat(sentence.Select(x=>char.IsUpper(x) ? ("AEIUO".Contains(x) ? "Iron Yard" : "Iron") : ("aeiuo".Contains(x) ? "Yard" : x.ToString())));
    }
  }
}

