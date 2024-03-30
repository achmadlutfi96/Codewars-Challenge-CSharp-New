// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
public class Cockroach
{
    public static int CockroachSpeed(double x)
    {
        //#Happy Coding! ^_^
        return (int) Math.Floor((x*100000)/3600);
    }
    public static void Main()
    {
        Console.WriteLine(CockroachSpeed(1.08));
    }
}
