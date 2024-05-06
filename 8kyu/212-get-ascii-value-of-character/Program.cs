using System;

public static class Kata
{
  public static int GetASCII(char c)
  {
    // throw new NotImplementedException();
    return Convert.ToByte(c);

    // Alternative
    // return c;
    // return (int) c;
  }

  public static void Main(){
    Console.WriteLine(GetASCII('A'));
  }
}