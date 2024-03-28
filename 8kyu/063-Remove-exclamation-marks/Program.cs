// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Kata
{
  public static string RemoveExclamationMarks(string s)
  {
    // Your code goes here
    return s.Replace("!", String.Empty);
  }
  public static void Main(){
    Console.WriteLine(RemoveExclamationMarks("!!"));
    Console.WriteLine(RemoveExclamationMarks("!?!"));
  }
}
