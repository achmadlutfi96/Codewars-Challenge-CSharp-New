using System;
using System.Linq;
public class Kata
{
  public static string StrongEnough(int[][] earthquake, int age)
  {
    // your code here
    double strong  = 1000;
    for (int i = 0; i < age; i++)
    {
        strong -= strong*1d/100d;
    }

    int totalEarthQuake = earthquake.Select(x=>x.Sum()).Aggregate((a,b)=>a*b);

    return strong > totalEarthQuake ? "Safe!" : "Needs Reinforcement!";

    // Alternative 
    // return earthquake.Aggregate(1,(s,n)=> s * n.Sum(e=>e))< 1000* Math.Pow(0.99,age) ?  "Safe!" : "Needs Reinforcement!";
  }

  public static void Main()
  {
    Console.WriteLine(StrongEnough(new int[][] {new int[] {5, 8, 7}, new int[] {3, 3, 1,}, new int[] {4, 1, 2}}, 2));
    Console.WriteLine(StrongEnough(new int[][] {new int[] {5, 8, 7}, new int[] {3, 3, 1,}, new int[] {4, 1, 2}}, 3));
  }

}