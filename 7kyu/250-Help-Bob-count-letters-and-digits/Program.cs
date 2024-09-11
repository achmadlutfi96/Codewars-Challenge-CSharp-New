using System;
using System.Linq;

public static class Kata
{
    public static int CountLettersAndDigits(string input)
    {
        //TODO:  
        // return input.Where(char.IsAsciiLetterOrDigit).Count();

        // Alternative
        return input.Where(char.IsLetterOrDigit).Count();
    }

    public static void Main(){
        Console.WriteLine(CountLettersAndDigits("n!!ice!!123"));
    }
}