using System;


public class CodeWars
{
  public static bool IsDigit(string s) 
  {
    //your code
    if (s == null) { return false; }
    try{
        Convert.ToDouble(s);
        return true;
    }catch(Exception e){
        return false;
    }

    // Alternative
    // return double.TryParse(s, out var _);
  }

  public static void Main(){
    Console.WriteLine(IsDigit("s2324"));
    Console.WriteLine(IsDigit(null));
  }
}