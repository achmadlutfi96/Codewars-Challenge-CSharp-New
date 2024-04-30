using System;
public class Kata
{
  public static double Calculator(double a, double b, char op)
  {
    return op switch {
        '+' => a+b,
        '*' => a*b,
        '/' => a/b,
        '-' => a-b,
        _ => throw new ArgumentException()
    };
  }

  public static void Main(){
    Console.WriteLine(Calculator(6, 2, '+'));
    Console.WriteLine(Calculator(6, 2, '$'));
  }
}