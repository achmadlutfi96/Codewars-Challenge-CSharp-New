using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static string ToLeetSpeak(string str)
  {
    Dictionary<char,char> dictStr = new Dictionary<char,char>(){
        { 'A' , '@'}, {'B' , '8' }, { 'C' , '(' }, { 'E' , '3' },
        { 'G' , '6'}, {'H' , '#' }, { 'I' , '!' }, { 'L' , '1' },
        { 'O' , '0'}, {'S' , '$' }, { 'T' , '7' }, { 'Z' , '2' } };
    return string.Concat(str.Select(x=>dictStr.ContainsKey(x) ? dictStr[x] : x));

    // Alternative
    // return string.Concat(str.Select(x => x != ' ' ? "@8(D3F6#!JK1MN0PQR$7UVWXY2"[x - 'A'] : x));
  }

  public static void Main(){
    Console.WriteLine(ToLeetSpeak("LEET"));
  }
}