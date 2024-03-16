// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Kata
{
    public static string Remove_char(string s)
    {
        // Your Code
        string temp = "";
        for(int i = 0; i < s.Length; i++){
            if(i == 0 || i == (s.Length-1)){
                continue;
            }
            temp += s[i];
        }
        return temp;

        // Alternative 1
        // return s.Substring(1,(s.Length - 2));
        // Alternative 2
        // return s.Remove(s.Length - 1, 1).Remove(0, 1);
    }
}

public class Program
{
    public static void Main(){
        Console.WriteLine(Kata.Remove_char("country"));
    }
}
