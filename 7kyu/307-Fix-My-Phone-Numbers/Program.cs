using System.Linq;
using System;
public class Kata
{
  public static String IsItANum(string str) {
    // your code here;
    string res = string.Concat(str.Where(x=>char.IsDigit(x)));
    return res.StartsWith("0") && res.Length == 11 ? res : "Not a phone number";

    // Alternative
    // var phone = Regex.Replace(str, @"\D", "");
    // return Regex.IsMatch(phone, @"^0\d{10}$") ? phone : "Not a phone number";
  }

  public static void Main(){
    Console.WriteLine(IsItANum("S:)0207ERGQREG88349F82!efRF)"));
    Console.WriteLine(IsItANum("sjfniebienvr12312312312ehfWh"));
  }
}