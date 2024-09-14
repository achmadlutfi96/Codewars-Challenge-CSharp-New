using System;

public static class Kata
{
  public static int? PreviousMultipleOfThree(int n)
  {
    while(n%3 != 0){
        n = n/10;
    }
    return n == 0 ? null : n; // your code ..

    // Alternative
    // return n == 0 ? null : n % 3 == 0 ? n : PreviousMultipleOfThree(n / 10);
  }

  public static void Main(){
    Console.WriteLine(PreviousMultipleOfThree(952406));
    Console.WriteLine(PreviousMultipleOfThree(25));
  }
}