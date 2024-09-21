using System.Text.RegularExpressions;

public class Kata
{
  public static int SubstringCount(string fullText, string searchText)
  {
    return Regex.Matches(fullText, searchText).Count();
  }

  public static void Main(){
    Console.WriteLine(SubstringCount("ccddeeccddeecc", "cc"));
  }
}