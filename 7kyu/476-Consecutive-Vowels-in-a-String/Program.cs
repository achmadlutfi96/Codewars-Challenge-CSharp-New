using System.Linq;
using System;
using System.Collections.Generic;
public class Kata {
  public static int GetTheVowels(string word) {
    char[] sv = word.Where("aeiou".Contains).ToArray();
    var res = new List<char>();
    for (int i = 0; i < sv.Length; i++)
    {
        if(sv[i]=='a' && (res.Count == 0 || res.LastOrDefault() == 'u')){
            res.Add(sv[i]);
        }
        if(sv[i] == 'e' && res.LastOrDefault() == 'a'){
            res.Add(sv[i]);
        }
        if(sv[i] == 'i' && res.LastOrDefault() == 'e'){
            res.Add(sv[i]);
        }
        if(sv[i] == 'o' && res.LastOrDefault() == 'i'){
            res.Add(sv[i]);
        }
        if(sv[i] == 'u' && res.LastOrDefault() == 'o'){
            res.Add(sv[i]);
        }
    }
    return res.Count();

    // Alternative
    // return word.Aggregate(0, (i, c) => i + (c == "aeiou"[i % 5] ? 1 : 0));
  }
  public static void Main()
  {
    Console.WriteLine(GetTheVowels("sudnfhrakekdhhfkakjdjdhvneidkvnudntomcnnamjemdmfudkfhjamvcjedkfdnridnmnbvfhbdjdidncbvchencchdjdodncvchfndnrnencncnffduncbhjdfja"));
  }
}