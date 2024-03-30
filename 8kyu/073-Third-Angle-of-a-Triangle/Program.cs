// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public static class Kata
{
  public static int OtherAngle(int a, int b)
  {
    // throw new NotImplementedException();
    return 180-a-b;
  }
  public static void Main(){
    Console.WriteLine(OtherAngle(30, 60));
  }
}
