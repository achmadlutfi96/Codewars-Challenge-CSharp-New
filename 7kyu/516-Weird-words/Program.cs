using System;
using System.Text;
public class Kata
{
  public static string NextLetter(string str)
  {
    StringBuilder res = new(str);
    for (int i = 0; i < res.Length; i++)
    {
        if(!char.IsLetter(res[i])){
            continue;
        }
        if(res[i] == 'Z'){
            res[i] = 'A';
            continue;
        }
        if(res[i] == 'z'){
            res[i] = 'a';
            continue;
        }
        res[i] = (char) (res[i]+1);
    }
    return res.ToString();

    // Alternative
    // return string.Concat(str.Select(c => char.IsLetter(c) ? (char) (c + ("zZ".Contains(c) ? -25 : 1)) : c));
  }

  public static void Main()
  {
    Console.WriteLine(NextLetter("Hello"));
    Console.WriteLine(NextLetter("My Name Is Zoo"));
  }
}