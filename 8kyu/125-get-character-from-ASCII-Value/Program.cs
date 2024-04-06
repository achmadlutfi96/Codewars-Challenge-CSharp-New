using System;
public class Kata
{
  public static char GetChar(int charcode)
  {
    // ...
    return (char)(charcode >> 32);
    // Alternative
    // return (char)charcode;
  }
  public static void Main(){
    Console.WriteLine(GetChar(55));
    Console.WriteLine(GetChar(64));
  }
}