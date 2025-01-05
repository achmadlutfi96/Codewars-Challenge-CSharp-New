using System;

class Kata
{
  public static long Pentagonal(long n)
  {
    if(n<1){
        return -1;
    }
    return 5 * (n * (n-1)/2) +1;
  }

  public static void Main()
  {
    Console.WriteLine(Pentagonal(1));
    Console.WriteLine(Pentagonal(2));
    Console.WriteLine(Pentagonal(3));
    Console.WriteLine(Pentagonal(4));
    Console.WriteLine(Pentagonal(8));
  }
}