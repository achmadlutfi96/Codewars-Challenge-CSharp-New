using System;
public class Kata
{
  public static bool CorrectTail(string body, string tail)
  {
    string sub = body.Substring(body.Length - (tail.Length));
    
    if (sub == tail) return true;
    else return false;

    // Alternative
    // return body.EndsWith(tail);
  }
  public static void Main(){
    Console.WriteLine(CorrectTail("Fox", "x"));
    Console.WriteLine(CorrectTail("Emu", "t"));
  }
}