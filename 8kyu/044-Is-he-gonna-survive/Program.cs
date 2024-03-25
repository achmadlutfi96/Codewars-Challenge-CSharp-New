// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
class Kata
{
    public static bool Hero(int bullets, int dragons)
    {
        //Do Some Magic...
        return bullets/2 >= dragons;
    }
    public static void Main(){
        Console.WriteLine(Hero(10, 5));
    }
}
