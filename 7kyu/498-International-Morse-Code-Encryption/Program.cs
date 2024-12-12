using System;
using System.Linq;

// Dictionary CHAR_TO_MORSE in the class Preloaded is already defined to convert characters into their Morse Code equivilant.
public class MorseEncrypt
{
  public static string ToMorse(string englishStr)
  {
    Console.Write(Preloaded.CHAR_TO_MORSE);
    return string.Join(" ",englishStr.Select(x=> x==' ' ? " " : Preloaded.CHAR_TO_MORSE[x]));
  }
}