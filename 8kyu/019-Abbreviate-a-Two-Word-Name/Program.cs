// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;

public class Kata
{
    public static string AbbrevName(string name)
    {
        string res="";
        res+=name[0];
        for(int i=1; i<name.Length;i++){
            if(name[i].Equals(' ')){
                res+='.';
                res+=name[i+1];
            }
        }
        return res.ToUpper();

        // Alternative
        // return string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();
    }
    public static void Main()
    {
        Console.WriteLine(AbbrevName("Sam Harris"));
    }
}
