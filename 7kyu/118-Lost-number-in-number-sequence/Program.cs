using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int FindDeletedNumber(List<int> startingList, List<int> mixedList)
  {
    // Your code here
    if(startingList.Count() == 0 && mixedList.Count() == 0){
        return 0;
    }
    List<int> result = startingList.Except(mixedList).ToList();
    return result.Count() == 0 ? 0 : result.First();

    // Alternative
    // return startingList.Except(mixedList).FirstOrDefault(0);
  }

  public static void Main(){
    Console.WriteLine(FindDeletedNumber(new List<int>(){1,2,3,4,5,6,7,8,9}, new List<int>(){5,7,1,9,4,8,2,3}));
  }
}