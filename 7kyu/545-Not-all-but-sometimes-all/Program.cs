using System.Collections.Generic;

public class Kata
{
  public static string Remove(string str, Dictionary<char,int> what)
  {
    string res = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (what.ContainsKey(str[i]) && what[str[i]] > 0)
        {
            what[str[i]]--;            
        }else{
            res += $"{str[i]}";
        }
    }
    return res;

    // Alternative
    // return new string(str.Where(c => !what.ContainsKey(c) || what[c]-- < 1).ToArray());
  }

  public static void Main()
  {
    Console.WriteLine(Remove("this is a string", new Dictionary<char,int> { {'t', 1 }, {'i', 2 }}));
  }
}