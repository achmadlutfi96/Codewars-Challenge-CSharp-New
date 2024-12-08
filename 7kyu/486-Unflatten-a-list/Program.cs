using System;
using System.Collections.Generic;
public class Kata
{
  public static object[] Unflatten(int[] flatArray)
  {
    var res = new List<object>();
    int i = 0;
    while(i < flatArray.Length){
        if(flatArray[i] < 3){
            res.Add(flatArray[i]);
            i++;
        }else if(i+flatArray[i] < flatArray.Length && flatArray[i] > 2 ){
            res.Add(flatArray.AsSpan(i,flatArray[i]).ToArray());
            i+=flatArray[i];
        }else{
            res.Add(flatArray.AsSpan(i, flatArray.Length-i).ToArray());
            i+=flatArray[i];
        }
    }
    return res.ToArray();

    // Alternative
    // List<object> output = new List<object>();
    //         for (int i = 0; i < flatArray.Count(); i++)
    //         {
    //             if (flatArray[i] < 3)
    //             {
    //                 output.Add(flatArray[i]);
    //             }
    //             else
    //             {
    //                 output.Add(flatArray.Skip(i).Take(flatArray[i]).ToList());
    //                 i = i + flatArray[i] -1;
    //             }
    //         }
    //         return output.ToArray();
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(", ", Unflatten(new int[] { 3, 5, 2, 1 })));
    Console.WriteLine(string.Join(", ",Unflatten(new int[] { 1, 4, 5, 2, 1, 2, 4, 5, 2, 6, 2, 3, 3 })));
  }
}