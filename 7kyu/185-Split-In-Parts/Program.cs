using System;
using System.Collections.Generic;

public class Kata
{
  public static string SplitInParts(string s, int partLength)
  {  
    //your code goes here
    List<string> parts = new List<string>();
    for (int i = 0; i < s.Length; i+=partLength)
    {
        if(i+partLength > s.Length){
            parts.Add(s.Substring(i));
            break;
        }else{
            parts.Add(s.Substring(i, partLength));
        }
    }

    return  string.Join(" ", parts);  

    // Alternative 1
    // for(int i = partLength; i < s.Length; i += partLength + 1)
    //     s = s.Insert(i, " ");
    // return s; 

    // Alternative 2
    // return string.Join(" ", Regex.Matches(s, $".{{1,{partLength}}}"));   
  }

  public static void Main(){
    Console.WriteLine(SplitInParts("supercalifragilisticexpialidocious",3));
  }
}  
