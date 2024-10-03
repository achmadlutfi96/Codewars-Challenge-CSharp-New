using System;
using System.Linq;

public class Kata
{
    public static bool ValidParentheses(string str)
    {
        while(str.Contains("()")){
            str = str.Replace("()","");
        }
        return str.Length == 0;
    }

    public static void Main(){
        Console.WriteLine(ValidParentheses("())(()"));
    }

}