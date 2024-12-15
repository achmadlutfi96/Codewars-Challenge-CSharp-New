using System;

public static class Kata
{  
  public static string ReverseFactorial(long num)
  {
    // throw new NotImplementedException();
    long res = 1;
    int i = 0;
    do{
        i++;
        res *= i;
    }while(res < num);
    return res == num ? $"{i}!" : "None";
  }

  public static void Main()
  {
    Console.WriteLine(ReverseFactorial(3628800));
    Console.WriteLine(ReverseFactorial(150));
  }
}