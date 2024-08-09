using System;

public static class Kata 
{
    public static string ToTime(int seconds) 
    {
        return $"{seconds/3600} hour(s) and {seconds%3600/60} minute(s)";
    }

    public static void Main(){
        Console.WriteLine(ToTime(323500));
    }
}