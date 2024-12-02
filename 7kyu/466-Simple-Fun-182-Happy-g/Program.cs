using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    public bool HappyG(string str)
    {
        //coding and coding..
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'g')
            {
                bool leftStrhasg = i > 0 && str[i - 1] == 'g';
                bool rightStrhasg = i < str.Length - 1 && str[i + 1] == 'g';

                if (!leftStrhasg && !rightStrhasg)
                {
                    return false;
                }
            }
        }

        return true;

        // Alternative 1
        // return !Regex.Replace(str, "gg+", "").Contains("g");

        // Alternative 2
        // return Regex.IsMatch(str,"^(g{2,}|[^g])+$");
    }

    public static void Main()
    {
        Console.WriteLine();
    }
}