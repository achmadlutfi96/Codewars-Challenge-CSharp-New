using System;
using System.Globalization;

public class Kata
{
  public static string ToCurrency(int price)
  {
    // ...
    return price.ToString("N0", CultureInfo.InvariantCulture);

    // Alternative
    // return price.ToString("N0");
  }

  public static void Main()
  {
    Console.WriteLine(ToCurrency(5678545));
  }
}