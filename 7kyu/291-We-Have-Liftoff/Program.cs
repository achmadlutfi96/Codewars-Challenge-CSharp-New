using System;
using System.Collections.Generic;

public static class Kata
{
    public static string Liftoff(List<int> instructions)
    {
        // throw new NotImplementedException();
        return string.Join(" ", instructions.OrderByDescending(x=>x)) + " liftoff!";  
    }

    public static void Main(){
        Console.WriteLine(Liftoff(new List<int> {2, 8, 10, 9, 1, 3, 4, 7, 6, 5}));
    }
}