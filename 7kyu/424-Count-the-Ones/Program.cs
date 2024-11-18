using System;
public class Kata
{
  public static int HammingWeight(int x)
  {
    // throw new NotImplementedException(); // replace with your code
    return Convert.ToString(x,2).Replace("0", "").Length;

    // Alternative
    // return x == 0 ? 0 : 1 + HammingWeight(x & (x - 1));
  }

  public static void Main()
  {
    Console.WriteLine(HammingWeight(21));
  }
}