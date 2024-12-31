using System;
using System.Linq;

namespace Kata
{
  public class WordGuesser
  {
    public int CountCorrectCharacters(string correctWord, string guess)
    {
        if(correctWord.Length != guess.Length) throw new InvalidOperationException();
        return correctWord.Where((v,i)=>v == guess[i]).Count();
    }
  }
}