using System;
public class Kata
{
  public static int CookingTime(int eggs)
  {
    // TODO
    return (int) Math.Ceiling((double)eggs/8) * 5;
  }

  public static void Main(){
    Console.WriteLine(CookingTime(10));
  }
}