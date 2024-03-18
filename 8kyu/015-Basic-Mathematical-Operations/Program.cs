// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Solution
{
  public static class Program
  {
    public static double basicOp(char operation, double value1, double value2)
    {
        switch(operation){
            case '+': return value1 + value2;
            case '-': return value1 - value2;
            case '*': return value1 * value2;
            case '/': return value1 / value2;
            default : return 0;   
        }
    }

    public static void Main(){
        Console.WriteLine(basicOp('+', 4, 7));
    }
  }
}
