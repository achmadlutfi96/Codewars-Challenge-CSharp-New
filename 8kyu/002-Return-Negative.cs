using System;

public static class Kata
{
  public static int MakeNegative(int number)
  {
    // Code?
    return number > 0 ? -number : number;
  }
}

public class ReturnNegative{
    public static void Main(string[] args){
        Console.WriteLine(Kata.MakeNegative(42));
    }
}