using System.Globalization;

public class Kata
{
  public static string FormatMoney(double amount)
  {
    // your formatting code 
    // return String.Format(new CultureInfo("en-US", false), "{0:c}", amount);
    return String.Format("${0:f2}", amount);
    
    // Alternative
    // return $"${amount:F2}";
    // return amount.ToString("$0.00");

    // Another
    // NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
    // nfi.CurrencyGroupSeparator = "";
    // return string.Format(nfi, "{0:C}", amount);
  }

  public static void Main(){
    Console.WriteLine(FormatMoney(39.99));
    Console.WriteLine(FormatMoney(3.1));
    Console.WriteLine(FormatMoney(3));
  }
}