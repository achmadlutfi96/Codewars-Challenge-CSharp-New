using System;
using System.Text.RegularExpressions;
public class Kata
{
  public static double? ParseF(object s = null)
  {
     try{
        if(!Regex.IsMatch((string)s, @"\d")){
            throw new Exception("");
        }
        return Convert.ToDouble(s);
    }catch{
        return null;
    }

    // Alternative
    // return double.TryParse(s?.ToString(), out var result) ? result : (double?) null;
  }

  public static void Main(){
    Console.WriteLine(ParseF("1"));
    Console.WriteLine(ParseF("ssds"));
  }
}