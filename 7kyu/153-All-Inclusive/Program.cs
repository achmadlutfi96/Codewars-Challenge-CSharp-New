using System;
using System.Collections.Generic;
using System.Linq;

public class Rotations
{
  public static Boolean ContainAllRots(string strng, List<string> arr) 
  {
      // your code
      return Enumerable.Repeat(strng , strng.Length).Select((x,i)=>x.Substring(i,strng.Length-i)+x.Substring(0,i)).Select(arr.Contains).All(x=>x == true);

      // Alternative
    // return !s.Where((c, i) => !arr.Contains((s + s).Substring(i, s.Length))).Any();
  }

  public static void Main(){
    Console.WriteLine(ContainAllRots("bsjq",new List<string>(){ "bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs" }));
  }
}