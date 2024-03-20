// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
public static class Clock
{
    public static int Past(int h, int m, int s)
    {
        //#Happy Coding! ^_^
        return (h*3600*1000)+(m*60*1000)+(s*1000);
        //Alternative
        // return (int)(new TimeSpan(h, m, s)).TotalMilliseconds;
        // return ((h * 60 + m) * 60 + s) * 1000;
    }
    public static void Main(){
        Console.WriteLine(Past(0,1,1));
    }
}