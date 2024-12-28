using System.Text.RegularExpressions;

static class SimpleExtensions {
  public static bool EightBitNumber(this string str) {
    // Your code here
    if (string.IsNullOrEmpty(str)) return false;
    
    // Check if the input is numeric and does not have leading zeros (except "0") 
    if (!Regex.IsMatch(str, @"^\d{1,3}$") || (str.Length > 1 && str[0] == '0') || Regex.IsMatch(str, @"\D")) 
        return false; 
    // Parse the number and check if it is within the 0-255 range 
    if (int.TryParse(str, out int number)) 
    { 
        return number >= 0 && number <= 255; 
    } 
    
    return false;

    // Alternative 1
    // return byte.TryParse(str, out var n) && s.Length == $"{n}".Length;

    // Alternative 2
    // return Regex.IsMatch(str, @"^([0-9]|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\z");
  }

  public static void Main()
  {
    Console.WriteLine("55".EightBitNumber());
    Console.WriteLine("042".EightBitNumber());
    Console.WriteLine("1\n".EightBitNumber());
  }
}