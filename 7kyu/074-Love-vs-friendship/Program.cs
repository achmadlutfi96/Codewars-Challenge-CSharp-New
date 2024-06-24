using System;
using System.Linq;

public static class Kata
{
  public static int WordsToMarks(string str)
  {
    // throw new NotImplementedException();
    return str.Select(x=>x-96).Sum();

    // Alternative
    // return str.Sum(c => c - 96);
  }

  public static void Main(){
    Console.WriteLine(WordsToMarks("friends"));
  }
}