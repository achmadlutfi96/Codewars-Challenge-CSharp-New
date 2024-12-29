using System;
namespace Solution {
  public class Kata
  {
    public static int EnsureEven(double number) 
    {
      // Code on squire...
      return (int)(number >= 0 ? 
        (Math.Floor(number)%2 == 0 ? Math.Floor(number) : Math.Floor(number)+(Math.Floor(number)%2)) : (Math.Floor(Math.Abs(number))%2 == 0 ? Math.Floor(Math.Abs(number)) : Math.Floor(Math.Abs(number))+(Math.Floor(Math.Abs(number))%2))*-1);

        // Alternative
        // return (int)Math.Round(number / 2, MidpointRounding.AwayFromZero) * 2;
    }

    public static void Main()
    {
        Console.WriteLine(EnsureEven(1));
        Console.WriteLine(EnsureEven(0.5));
        Console.WriteLine(EnsureEven(-1));
        Console.WriteLine(EnsureEven(-0.5));
        Console.WriteLine(EnsureEven(1.356));
    }
  }
}