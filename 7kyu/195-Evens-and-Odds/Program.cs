using System;

public static class Kata
{
  public static string EvensAndOdds(int num)
  {
    // throw new NotImplementedException();

    // "B" for binary format & "X" for Hexadecimal format
    // link: https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
    return num%2==0 ? string.Format("{0:b}", num) : string.Format("{0:x}",num);

    // Alternative 
    // return Convert.ToString(num, num % 2 == 0 ? 2 : 16);
  }

  public static void Main(){
    Console.WriteLine(EvensAndOdds(47));
    Console.WriteLine(EvensAndOdds(2));
    Console.WriteLine(EvensAndOdds(13));
    Console.WriteLine(EvensAndOdds(12800));
    Console.WriteLine(EvensAndOdds(0));
  }
}