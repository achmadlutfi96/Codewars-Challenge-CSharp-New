using System;

public class Kata
{
  public static int Remainder(int a, int b)
  {
    // throw new NotImplementedException();
    return a >= b ? a%b : b%a;
  }

  public static void Main(){
    Console.WriteLine(Remainder(17, 5));
  }
}