using System;
using System.Linq;
public class Kata
{
    public static bool SubstringTest(string str1, string str2)
    {
        //Code goes here!
        for (int i = 0; i < str2.Length - 1; i++)
        {
            for (int j = 2; j <= str2.Length - i; j++)
            {
                if (str1.ToLower().Contains(str2.Substring(i, j).ToLower()))
                {
                    return true;
                }
            }
        }
        return false;

        // Alternative 1
        // return str1.Any() && Enumerable.Range(0, str1.Length - 1).Any(i => str2.ToLower().Contains(str1.ToLower()[i..(i + 2)]));

        // Alternative 2
        // str1 = str1.ToLower();
        // str2 = str2.ToLower();
        // return Enumerable.Range(0, (str2.Length / 1))
        //         .Any(index => str2.Length - index != 1 && str1.Contains(str2.Substring(index * 1, 2)));
    }

    public static void Main()
    {
        Console.WriteLine(SubstringTest("Something", "Home"));
        Console.WriteLine(SubstringTest("Something", "Fun"));
        Console.WriteLine(SubstringTest("Codewars is Sweet!", "is"));
    }
}