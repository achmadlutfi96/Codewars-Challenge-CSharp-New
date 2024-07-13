using System;
using System.Linq;

public class Kata {
  public static char AddLetters(char[] letters) {
    // your code here
    if (letters.Length == 0) return 'z';
    string alphabet = " abcdefghijklmnopqrstuvwxyz";
    int res =letters.Select(x=>alphabet.IndexOf(x)).Sum();
    return res > 26 ? alphabet[res%26] : alphabet[res];

    // Alternative
    // var val = letters.Sum(c => c-96) % 26;
    // return val == 0 ? 'z' : (char)(val + 96);
  }

  static void Main(){
    Console.WriteLine(AddLetters(new char[] {'a', 'b', 'c'}));
    Console.WriteLine(AddLetters(new char[] {'z', 'a'}));
    Console.WriteLine(AddLetters(new char[] {'z'}));
    Console.WriteLine(AddLetters(new char[] {}));
  }
}

