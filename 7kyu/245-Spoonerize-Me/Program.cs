using System;
using System.Linq;

public static class ReadySet
{
  public static string Spoonerize(string str)
  {
    string[] letters = str.Split(" ");
    string firstLetter = letters.First();
    string lastLetter = letters.Last();
    string tempFirstLetter = "";
    string tempLastLetter = "";

    for (int i = 0; i < firstLetter.Length; i++)
    {
        if(("aiueo".Contains(char.ToLower(firstLetter[i])) && i != 0) || i == 1){
            firstLetter = firstLetter.Substring(i);
            break;
        }
        tempLastLetter  += firstLetter[i]; 
    }

    for (int i = 0; i < lastLetter.Length; i++)
    {
        if(("aiueo".Contains(char.ToLower(lastLetter[i]))&& i != 0) || i == 1){
            lastLetter = lastLetter.Substring(i);
            break;
        }
        tempFirstLetter  += lastLetter[i]; 
    }

    firstLetter = tempFirstLetter + firstLetter;
    lastLetter = tempLastLetter + lastLetter;
    if( letters.Length > 3){
        return $"{firstLetter} {string.Join(' ', letters.Skip(1).SkipLast(1))} {lastLetter}";
    }else if (letters.Length == 3){
        return $"{firstLetter} {letters[1]} {lastLetter}";
    }else{
        return $"{firstLetter} {lastLetter}";
    }

    // Alternative 1
    // string[] words = str.Split(' ');
    // return words[1][0] + words[0][1..] + ' ' + words[0][0] + words[1][1..];

    // Alternative 2
    // char[] chars = str.ToCharArray();
    // chars[0] = str[str.IndexOf(' ') + 1];
    // chars[str.IndexOf(' ') + 1] = str[0];
    // return new string(chars);
  }

  public static void Main(){
    Console.WriteLine(Spoonerize("flat battery"));
    Console.WriteLine(Spoonerize("pack of lies"));
  }
}