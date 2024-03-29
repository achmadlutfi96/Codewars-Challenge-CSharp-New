// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Kata {
  public static bool SetAlarm(bool employed, bool vacation) {
    // your code here
    return employed && !vacation;
  }
  public static void Main(){
    Console.WriteLine(SetAlarm(true, true));
    Console.WriteLine(SetAlarm(false, true));
    Console.WriteLine(SetAlarm(true, false));
    Console.WriteLine(SetAlarm(false, false));
  }
}