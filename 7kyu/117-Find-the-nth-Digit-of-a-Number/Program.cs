public class Kata
{
  public static int FindDigit(int num, int nth)
  {
    string digit = Math.Abs(num).ToString();
    return digit.Length < nth ? 0 : nth < 1 ? -1 : (int) char.GetNumericValue(digit.Reverse().ToArray()[nth-1]);

    // Alternative
    // return nth <= 0 ? -1 : (int) Math.Abs(num / Math.Pow(10, nth - 1) % 10);
  }

  public static void Main(){
    Console.WriteLine(FindDigit(-2825, 3));
  }
}