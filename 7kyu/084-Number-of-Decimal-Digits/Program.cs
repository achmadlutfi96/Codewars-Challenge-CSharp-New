using System;
public class DecTools {
  public static int Digits(ulong n) {
    return n.ToString().Length;
  }

  public static void Main(){
    Console.WriteLine(Digits(9876543210ul));
  }
}
