using System;
public class Kata
{
  public static int HexToDec(string hexString)
  {
    return hexString.Contains('-') ? -Convert.ToInt32(hexString.Replace("-",""), 16) : Convert.ToInt32(hexString, 16);

    // Alternative
    // return Convert.ToInt32(hexString.TrimStart('-'), 16) * (hexString[0] == '-' ? -1 : 1);
  }

  public static void Main(){
    Console.WriteLine(HexToDec("-C"));
  }
}