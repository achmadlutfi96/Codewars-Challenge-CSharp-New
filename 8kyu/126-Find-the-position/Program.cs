
public class Kata
{
  public static string Position(char alphabet)
  {
    return $"Position of alphabet: {((int)alphabet)-96}";
    // Alternative
    // return $"Position of alphabet: {(1 + alphabet - 'a')}";
  }
  public static void Main(){
    Console.WriteLine(Position('a'));
    Console.WriteLine(Position('z'));
  }
}