// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Kata
{
  public static string SayHello(string name)
  {
    return $"Hello, {name}"; 
  }
  public static void Main(){
    Console.WriteLine(SayHello("Mr. Spock"));
  }
}