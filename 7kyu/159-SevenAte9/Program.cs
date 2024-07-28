using System;
using System.Text;
using System.Text.RegularExpressions;

public class Kata
{
    public static string SevenAteNine(string str)
    {
        // Solve it
        StringBuilder textnew = new StringBuilder(str);
        for (int i = 1; i < textnew.Length-1; i++)
        {
            if(textnew[i] == '9' && textnew[i-1] == '7' && textnew[i+1] == '7'){
                textnew.Remove(i,1);
            }
        }

        return textnew.ToString();

        //  Alternative
        // return Regex.Replace(str, @"(?<=7)9(?=7)", ""); 
    }

    public static void Main()
    {
        Console.WriteLine(SevenAteNine("165561786121789797"));
    }
}