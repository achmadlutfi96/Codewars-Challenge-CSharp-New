using System;
using System.Linq;

public class Kata
{
  public static int[] FindAll(int[] array, int n)
  {
    // your code here
    return array.Select((v, i)=> v == n ? i : -1).Where(x=> x >= 0).ToArray();
  }

  public static void Main(){
    Console.WriteLine(string.Join(",",FindAll(new int[] {6, 9, 3, 4, 3, 82, 11}, 3)));
  }
}