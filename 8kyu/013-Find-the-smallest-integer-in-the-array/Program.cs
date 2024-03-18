// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;

public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
        // return args.Min();
        return args.Min<int>(); // Pakai LINQ
    }
    public static void Main(){
        Console.WriteLine(FindSmallestInt(new int[]{78,56,232,12,11,43}));
    }
}
