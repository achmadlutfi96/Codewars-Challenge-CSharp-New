// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;

class Kata
{
    public static int StrCount(string str, char letter)
    {
        return String.Join("",str.ToCharArray().Where(s => Char.Equals(s, letter))).Length; //Do Some Magic
        // Alternative
        // return str.Count(a => a.Equals(letter));
    }
    public static void Main(){
        Console.WriteLine(StrCount("Hello", 'o'));
        Console.WriteLine(StrCount("Hello", 'l'));
        Console.WriteLine(StrCount("Hello", 'p'));
        Console.WriteLine(StrCount("", 'z'));
        
    }
}
