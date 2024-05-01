using System;
public class Kata
{
  public static int Multiply(int number)
  {
    //your code here
    return (int)(number * Math.Pow(5, Math.Abs(number).ToString().Length));
  }
  public static void Main(){
    Console.WriteLine(Multiply(200));
    Console.WriteLine(Multiply(-2));
  }
}