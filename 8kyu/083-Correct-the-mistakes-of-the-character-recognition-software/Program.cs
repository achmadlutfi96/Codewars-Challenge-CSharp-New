// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Kata
{
  public static string Correct(string text)
  {
    return text.Replace('1','I').Replace('5','S').Replace('0', 'O');
  }
  public static void Main(){
    Console.WriteLine(Correct("51NGAP0RE"));
  }
}
