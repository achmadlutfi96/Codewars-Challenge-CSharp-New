using System;
using System.Linq;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    // Code on you crazy diamond!
    foreach (var item in str)
    {
        if(str.Where(x => char.ToLower(x) == char.ToLower(item)).Count() > 1){
            return false;
        }
    }
    return true;

    // Alternative
    // return str.ToLower().Distinct().Count()==str.Length;
  }

  public static void Main(){
    Console.WriteLine(IsIsogram("Dermatoglyphics"));
    Console.WriteLine(IsIsogram("aba"));
  }
}