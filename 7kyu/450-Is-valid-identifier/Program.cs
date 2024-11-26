using System;
using System.Linq;
using System.Text.RegularExpressions;

public class IdentifierChecker 
{
  public static bool IsValid(String idn)
  {
    // here's your code...
    if(idn.Length < 1){
        return false;
    }
    if(char.IsDigit(idn[0]) || idn[0] == '!'){
        return false;
    }
    if(idn.Any(x=>"- ".Contains(x))){
      return false;
    }
    return true;

    // Alternative 1
    // return new Regex(@"^[a-z_\$][a-zA-Z0-9_\$]*$").Match(idn).Success;

    // Alternative 2
    // return Regex.IsMatch(idn, "^[$_a-zA-Z]+[\\w]$");

    // Alternative 3
    // return Regex.IsMatch(idn, @"^[a-z_\$]+[\w\$]*$", RegexOptions.IgnoreCase);
  }

  public static void Main()
  {
    Console.WriteLine(IsValid("i"));
  }
}