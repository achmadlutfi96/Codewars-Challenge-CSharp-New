using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static IEnumerable<string> FriendOrFoe(string[] names)
    {
        // Good luck!
        return names.Where(x => x.Length == 4);
    }

    public static void Main(){
        foreach (var item in FriendOrFoe(new string[]{ "Ryan", "Kieran", "Mark", "Jimmy" }))
        {
            Console.WriteLine(item);
        }
    }
}