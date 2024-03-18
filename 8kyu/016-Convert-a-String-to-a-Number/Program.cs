// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
public class Kata
{
    public static int StringToNumber(String str)
    {
        //TODO: Convert str into a number
        return Convert.ToInt32(str);
    }

    public static void Main(){
        Console.WriteLine(StringToNumber("1"));
    }
}
