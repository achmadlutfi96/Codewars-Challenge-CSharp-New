// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Kata
{
  public static string SwitchItUp(int number)
  {
    return number switch{
        1 => "One",
        2 => "Two",
        3 => "Three",
        4 => "Four",
        5 => "Five",
        6 => "Six",
        7 => "Seven",
        8 => "Eight",
        9 => "Nine",
        _ => "Zero"
    };
  }
  public static void Main(){
    Console.WriteLine(SwitchItUp(1));
  }
}
