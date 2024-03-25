// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public static class Kata
{
    public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
    {
        // throw new NotImplementedException();
        return distanceToPump <= mpg*fuelLeft;
    }
    public static void Main()
    {
        Console.WriteLine(ZeroFuel(50, 25, 2));
        Console.WriteLine(ZeroFuel(100, 50, 1));
    }
}
