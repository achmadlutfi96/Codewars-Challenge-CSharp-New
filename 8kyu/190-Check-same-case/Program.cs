using System.Text.RegularExpressions;
public class Kata {
  public static int SameCase(char a, char b) {
    if(Regex.IsMatch(a.ToString(), @"[^a-zA-Z]") || Regex.IsMatch(b.ToString(), @"[^a-zA-Z]")){
        return -1;
    }
    return Regex.IsMatch(a.ToString(), @"[A-Z]") == Regex.IsMatch(b.ToString(), @"[A-Z]") ? 1 : 0;

    // Alternative 1
    // if (!char.IsLetter(a) || !char.IsLetter(b))
    //   return -1;
    // return char.IsLower(a) == char.IsLower(b) ? 1 : 0; 

    // Alternative 2
    // return char.IsLetter(a) && char.IsLetter(b) ? (a & 96) == (b & 96) ? 1 : 0 : -1;
  }

  public static void Main(){
    Console.WriteLine(SameCase('a', 'u'));
    Console.WriteLine(SameCase('a', '*'));
  }
}