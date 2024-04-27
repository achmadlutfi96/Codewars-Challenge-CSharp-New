using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidateUsr(string username) 
  {
    // use regex here
    return Regex.IsMatch(username, @"\A[a-z0-9_]{4,16}\z");

    // Alternative
    // return Regex.IsMatch(username, "^[a-z0-9_]{4,16}$");
  }

  public static void Main(){
    Console.WriteLine(ValidateUsr("asd43_34"));
    Console.WriteLine(ValidateUsr("asd43 34"));
  }
}