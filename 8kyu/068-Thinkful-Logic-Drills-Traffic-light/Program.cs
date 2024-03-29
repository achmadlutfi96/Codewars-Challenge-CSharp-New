// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Collections.Generic;

public class Kata
{
    public static string UpdateLight(string current)
    {
        //Do Some Magic
        return new Dictionary<string, string>(){
            {"green","yellow"},
            {"yellow", "red"},
            {"red","green"}} [current];
    }
    public static void Main(){
        Console.WriteLine(UpdateLight("green"));
    }
}
