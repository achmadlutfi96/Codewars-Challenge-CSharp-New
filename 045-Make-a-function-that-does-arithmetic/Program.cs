using System;

public class Kata 
{
  public static double Arithmetic(double a, double b, string op) 
  {
    // throw new NotImplementedException();

    return op switch{
        "add" => a+b,
        "subtract"=>a-b,
        "multiply" => a*b,
        "divide" => a/b,
        _ => 0
    };
  }

  public static void Main(){
    Console.WriteLine(Arithmetic(8, 2, "subtract"));
  }
}