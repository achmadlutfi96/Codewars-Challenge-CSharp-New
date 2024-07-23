using System;

public static class Calculator
{
  public static double Execute(double num1, char op, double num2)
  {
    // throw new NotImplementedException();
    if( op == '/' && num2 == 0){
        throw new ArgumentException();
    }
    return op switch{
        '*' => num1 * num2,
        '/' => num1 / num2,
        '+' => num1 + num2,
        '-' => num1 - num2,
        _ => throw new ArgumentException()
    };

    // Alternative
    // return op switch
    // {
    //     '+' => num1 + num2,
    //     '-' => num1 - num2,
    //     '*' => num1 * num2,
    //     '/' => num2 == 0 ? throw new ArgumentException() : num1 / num2,
    //     _ => throw new ArgumentException()
    // };
  }

  public static void Main(){
    Console.WriteLine(Execute(3.2,'+', 8));
    Console.WriteLine(Execute(0,'/', 1));
  }
}