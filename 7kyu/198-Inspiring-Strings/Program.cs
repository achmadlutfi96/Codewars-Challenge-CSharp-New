public class Kata
{
  public static string LongestWord(string stringOfWords)
  {
    //Give me back the longest word!
    return stringOfWords.Split(" ").OrderBy(x=>x.Length).Last();
  }

  public static void Main(){
    Console.WriteLine(LongestWord("one two three"));
  }
}