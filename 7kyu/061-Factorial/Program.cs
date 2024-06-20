using System;

public static class Kata
{
  public static int Factorial(int n)
  {
    if (n < 0 || n > 12) {
        throw new ArgumentOutOfRangeException();
    }
    int result = 1;
    for (int i = 1; i <= n ; i++){
        result *= i;
    }
    return result;

    // Alternative
    // return Enumerable.Range(1, n).Aggregate(1, (x,y) => x * y);
  }

  public static void Main(){
    Console.WriteLine(Factorial(3));
  }
}