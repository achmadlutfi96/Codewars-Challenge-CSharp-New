using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int[] VowelIndices(string word)
  {
    // your code here
    List<int> indexVowel = new List<int>();
    for (int i = 0; i < word.Length; i++){
        if("aiueoy".Contains(char.ToLower(word[i]))){
            indexVowel.Add(i+1);
        }
    }
    return indexVowel.ToArray();

    // Alternative
    // return word.Select((x, i) => ++i).Where(x => "aoueiyAEIOUY".Contains(word[x - 1])).ToArray();
  }

  public static void Main(){
    foreach (var item in VowelIndices("orange"))
    {
        Console.Write(item+" ");        
    }
  }
}