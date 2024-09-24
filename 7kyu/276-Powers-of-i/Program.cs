using System;

public class Kata {

  public static string Pofi(int n) {
    return (n%4) switch 
    {
        1 => "i",
        2 => "-1",
        3 => "-i",
        _ => "1" 
    };

    // Alternative
    // return new[] { "1", "i", "-1", "-i" }[n % 4];
  }

  public static void Main(){
    Console.WriteLine(Pofi(0));
    Console.WriteLine(Pofi(1));
    Console.WriteLine(Pofi(2));
    Console.WriteLine(Pofi(3));
    Console.WriteLine(Pofi(4));
  }

}