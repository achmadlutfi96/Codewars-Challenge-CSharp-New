using System;
public class Kata
{
  public static int LargestPower(int n)
  {
    // Code goes here.
    // Watch out for overflows!
    int k = -1;
    while (Math.Pow(3, k+1) < n){
      k++;
    }
    return k;

    // Alternative
    // return (int)Math.Ceiling(Math.Log(n, 3)) - 1;
  }

  public static void Main(){
    Console.WriteLine(LargestPower(3));
    Console.WriteLine(LargestPower(4));
  }
}