using System;

public static class Kata
{
  public static string AddBinary(int a, int b)
  {
   // your code ...
//    return (a + b).ToString("B"); // "B" for Binary
    return Convert.ToString(a+b, 2);
     
  }

  public static void Main(){
    Console.WriteLine(AddBinary(5, 9));
  }
}