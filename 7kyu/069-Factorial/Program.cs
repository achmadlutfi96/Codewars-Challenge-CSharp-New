using System;

namespace Solution
{
  public static class Program
  {
    public static ulong Factorial(int n)
    {
        if (n <= 1){
            return 1;
        }else{
            return (ulong) n * Factorial(n-1);
        }

        // Alternative
        // return (n == 0) ? 1 : n * factorial(n-1);
    }

    public static void Main(string[] args){
        Console.WriteLine(Factorial(5));
    }
  }
}