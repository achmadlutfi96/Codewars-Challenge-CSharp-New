using System;
public class Power
{
  public static bool PowerOf4(object n)
  {

    if(n == null || n.GetType() != typeof(int)){
        return false;
    }
    long res = 1;
    while (res < (int)n)
    {
        res *= 4;
    }
    return res == (int) n;

    // Alternative
    // return n != null && n is int && Math.Log((int)n, 4) % 1 == 0;
  }

  public static void Main()
  {
    Console.WriteLine(PowerOf4(0));
    Console.WriteLine(PowerOf4(4));
    Console.WriteLine(PowerOf4(72));
    Console.WriteLine(PowerOf4(20));
    Console.WriteLine(PowerOf4(12));
    Console.WriteLine(PowerOf4(16));
    Console.WriteLine(PowerOf4(1));
    Console.WriteLine(PowerOf4(3.1415));
    Console.WriteLine(PowerOf4("4"));
    Console.WriteLine(PowerOf4(null));
  }
}