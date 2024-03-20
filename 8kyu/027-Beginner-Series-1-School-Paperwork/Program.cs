// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
public static class Paper
{
    public static int Paperwork(int n, int m)
    {
        //#Happy Coding! ^_^
        return n < 0 || m < 0 ? 0 : n * m;
    }
    public static void Main()
    {
        Console.WriteLine(Paperwork(5, -5));
    }
}

