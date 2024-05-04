using System;
public class Sleigh
{
  public static bool Authenticate(string name, string password)
  {
    // TODO
    return name.Equals("Santa Claus") && password.Equals("Ho Ho Ho!");
  }

  public static void Main(){
    Console.WriteLine(Authenticate("Santa Claus", "Ho Ho Ho!"));
  }
}