using System.Text.RegularExpressions;

static class SimpleExtensions {
  public static bool SixBitNumber(this string str) {
    // Your code here
    if (str.Contains("\n")) { return false; }
    return Regex.IsMatch(str, @"^(0|[1-5]?\d|6[0-3])$");
  }
}