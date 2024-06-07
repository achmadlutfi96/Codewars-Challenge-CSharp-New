using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    return (pin.Length == 6 || pin.Length == 4) && pin.Where( s =>Regex.IsMatch(s.ToString(), @"[^0-9]")).Count() == 0;

    // Alternative non REGEX
    // return pin.All(n => Char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);

    // Alternative with REGEX
    // return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
    // Explaned: \z: match the end of a WHOLE string (absolute end).
  }

  public static void Main(){
    Console.WriteLine(ValidatePin("1234"));
  }
}